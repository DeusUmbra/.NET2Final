using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectTV
{ // Todd Vogel
    public partial class MainForm : Form
    {
        int Score = 1000; //Initial Score
        DateTime date = DateTime.Today; //Get the date for later
        string initials = null; //Set up for getting initials later
        bool Running = false; //Is the game running
        bool finish = false; //Did they win?
        Dictionary<string, string> itemInspects = new Dictionary<string, string>(); //This is to hold all the
                                 //Strings that will give the explanation of items when they are inspected.
        public MainForm()
        {
            InitializeComponent(); //We will now populate the itemInspects dictionary!
            itemInspects.Add("Front Door", "Its a sturdy door with multiple locks, most of which you unlock easily, but it also has a padlock preventing the door from opening.");
            itemInspects.Add("Couch", "It's an ugly red couch, the cushions look old and one looks like it was just patched up recently.");
            itemInspects.Add("Trash Pile", "Its a huge pile of trash, disgusting!");
            itemInspects.Add("Bathroom", "It's a bathroom, but the light seems to be burnt out and it's pitch black inside.");
            itemInspects.Add("Desk", "It's covered in old newspapers and most of the drawers are missing except one but it won't open.");
            itemInspects.Add("Desk(Opened)", "Still covered in newspapers, but at least the drawer isn't stuck anymore!");
            itemInspects.Add("Small Box", "It's a small black box. It seems to be locked, I'd look for a little key!");
            itemInspects.Add("Window", "You look out the window and see you are very high up and don't recognize where you are.");
            itemInspects.Add("Window(Broken)", "It's the window you broke, did you break it for a good reason, or were you just releasing some frustration?");
            itemInspects.Add("Glass Shards", "It's a bunch of broken glass shards, most are just tiny bits, but one looks about as big as a knife!");
            itemInspects.Add("Hammer", "It's a regular hammer. What, you were expecting more? Ok sure, the handle is red I guess.");
            itemInspects.Add("Lighter", "It's a lighter, it makes things lighter when you light it and it can be used to light other things, but each time you light it, the lighter gets lighter.");
            itemInspects.Add("Large Key", "Its a good size key, looks kinda old and dirty.");
            itemInspects.Add("Small Key", "Its a small key, probably for a padlock.");
            itemInspects.Add("Old Trunk", "Its a dirty old trunk, looks like it needs a decently big key to open it.");
            itemInspects.Add("Big Glass Shard", "It slices your hand just holding this, but it should work for whatever you hope to cut open.");
            itemInspects.Add("Sledgehammer", "It's basically a really big hammer, you could do some damage with this thing!");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) //Quit out entirely
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) //Set up and play the game!
        {
            newGameToolStripMenuItem.Enabled = false; //Disabled to prevent accidental restarting.
            initials = null; //Reset incase this is a second run.
            finish = false;
            aboutToolStripMenuItem.Enabled = false; //Don't want this to erase game text!
            infoBox.Text = "You wake up in a strange studio appartment you don't recognize. You don't know how you got here," +
                " you don't know who brought you here, and you don't know why you're here, all you know is that you want out!" +
                " It's a bit dark in here but you can still see well enough thanks to the one window in the room.";
            roomObjects.Items.Add("Front Door");
            roomObjects.Items.Add("Couch"); //Populate the room list
            roomObjects.Items.Add("Desk");
            roomObjects.Items.Add("Trash Pile");
            roomObjects.Items.Add("Small Box");
            roomObjects.Items.Add("Window");
            roomObjects.Items.Add("Bathroom");
            Score = 1000;
            Running = true;
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e) //End the game, submitting the player's info
        {
            using(GameOverForm go = new GameOverForm()) //Get initials for submitting highscore
            {
                go.ShowDialog();
                initials = go.getInitials();
            }
            UploadScore(); //Upload the user's score
            endGameToolStripMenuItem.Enabled = false; //Reset the form to defaults
            newGameToolStripMenuItem.Enabled = true;
            aboutToolStripMenuItem.Enabled = true;
            roomObjects.Items.Clear();
            playerObjects.Items.Clear();
            infoBox.Text = "Welcome Player! Are you ready to play? Just click New Game! Want to see some Highscores? Just click Highscores! Confused? Click About!";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //Explain the game to the player.
        {
            infoBox.Text = "This is an escape game, if you don't know what that is it's simple: " +
                "Your goal is to escape the room without locking yourself in for good. Interact with objects in the room to try and escape!" +
                " At the end of the game, you will be asked for your initials and your score will be recorded in the Highscore table. " +
                "Try your best to make it out as quickly and simply as possible." +
                "   A game by Todd Vogel";
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e) //Show the highscore info
        {
            HighscoreForm highscoreForm = new HighscoreForm();
            highscoreForm.ShowDialog(); //This prevents the user from interacting with the game while viewing highscores.
        }

        private void btnHint_Click(object sender, EventArgs e) //Give a hint to the player, might be useful, might not be useful.
        {
            if (Running) //This prevents the user from causing errors by trying to interact with the game while it is not running.
            { //This first bit is an array of hints.
                string[] HintArray = { "Think outside the box!", "You can always give up!", "Have you tried Googling it?", "Have you looked at everything?",
                "Whatever you do, don't lick anything, it's never a good idea.", "Call George Lucas, maybe he has an idea!", "Did you know you can use items together?",
                "If it sounds like a bad idea it still might work!"};
                Random ran = new Random(); //Get a random number generator set up
                Score -= 10; //Lower the user's score for trying to get hints!
                int hintNum = ran.Next(0, HintArray.Length); //Get a random number
                MessageBox.Show(HintArray[hintNum]); //Show the hint!
            }
        }

        private void btnGiveUp_Click(object sender, EventArgs e) //Let the player quit but still submit their score
        {
            if (Running)
            {
                endGameToolStripMenuItem.Enabled = true; //Now the user can submit their score and reset the game.
                Score -= 1000; //I mean, they did give up, obviously they should lose points!
                Running = false; //Game is no longer running.
                infoBox.Text = "You decide to give up and just sit and wait for someone to rescue you. Guess how well that worked out for you, hint: Not well.";
            }
        }

        private void btnRoomUse_Click(object sender, EventArgs e) //If something from the Room list is used
        {
            if (Running)
            {
                if (roomObjects.SelectedItem != null) //Make sure something was selected.
                {
                    string use = roomObjects.SelectedItem.ToString(); //Get the selected item as a string.
                    if (use.Equals("Front Door"))
                    {
                        infoBox.Text = "You pull on the door for a while but it doesn't budge, seems you'll need a key for that padlock on the side.";
                        Score -= 2;
                    }
                    else if (use.Equals("Couch")) //Different things that could happen based on what was used.
                    {
                        infoBox.Text = "Why are you trying to pick up the couch? Did you think it would fit in your pockets or something?";
                        Score -= 2;
                    }
                    else if (use.Equals("Desk"))
                    {
                        infoBox.Text = "You pull on the drawer but it doesn't open.";
                        Score -= 2;
                    }
                    else if (use.Equals("Trash Pile"))
                    {
                        infoBox.Text = "You dig through the nasty trash pile and discover that it was hiding an old trunk!";
                        Score += 5;
                        roomObjects.Items.Add("Old Trunk"); //Sometimes using something causes new items to appear!
                        roomObjects.Items.Remove(use);
                    }
                    else if (use.Equals("Old Trunk"))
                    {
                        infoBox.Text = "You try to pry it open with your hands but it won't budge, looks like you will need a key.";
                        Score -= 2;
                    }
                    else if (use.Equals("Bathroom"))
                    {
                        infoBox.Text = "You 'use the bathroom' in the super dark bathroom. Eh, not like it's your apartment, so what do you care?";
                        Score -= 2;
                    }
                    else if (use.Equals("Small Box"))
                    {
                        infoBox.Text = "You picked up the box, it's still locked though.";
                        Score += 5;
                        roomObjects.Items.Remove(use); //This is to try picking up something in the environment and add it to the player inventory
                        playerObjects.Items.Add(use);
                    }
                    else if (use.Equals("Window"))
                    {
                        Score -= 2;
                        infoBox.Text = "You try to open the window but it won't budge.";
                    }
                    else if (use.Equals("Window(Broken)")) //Sometimes using everything is a bad idea.
                    {
                        Score -= 500;
                        Running = false;
                        endGameToolStripMenuItem.Enabled = true;
                        infoBox.Text = "You jump out the window, I think it's pretty obvious what happened next. Game Over";
                    }
                    else if (use.Equals("Glass Shards"))
                    {
                        infoBox.Text = "You carefully grab the one large glass shard, what are you planning to do with that?";
                        Score += 10;
                        playerObjects.Items.Add("Big Glass Shard");
                        roomObjects.Items.Remove("Glass Shards");
                    }
                    else //Just in case i forgot something.
                    {
                        infoBox.Text = "How are you planning to use that exactly? ...That's what I thought.";
                        Score -= 2;
                    }
                }
            }
        }

        private void btnPlayerUse_Click(object sender, EventArgs e) //If something from the Player list is used
        {
            if (Running)
            {
                if (playerObjects.SelectedItem != null)
                {
                    string use = playerObjects.SelectedItem.ToString();
                    if (use.Equals("Small Box")) //These are mostly for getting hints on what you can use the item for.
                    {
                        infoBox.Text = "Hard to unlock something with just your hands buddy, the key is probably pretty small and might be lost somewhere.";
                        Score -= 1;
                    }
                    else if (use.Equals("Lighter"))
                    {
                        infoBox.Text = "You flick on the lighter, its not very bright but it does make a difference. You then turn it off to not waste fuel.";
                        Score -= 1;
                    }
                    else if (use.Equals("Hammer"))
                    {
                        infoBox.Text = "You swing the hammer around a bit, you imagine it could break something that isn't too strong, like glass.";
                        Score -= 1;
                    }
                    else if (use.Equals("Big Glass Shard"))
                    {
                        infoBox.Text = "You wince holding this shard, it hurts and definitely cuts, but probably wouldn't cut anything tough. Maybe it would cut something " +
                            "flimsy or has recently been patched, like a bed sheet or something.";
                        Score -= 1;
                    }
                    else //In case something was used that won't have much use or any clear hints.
                    {
                        infoBox.Text = "How are you planning to use that exactly? ...That's what I thought.";
                        Score -= 1;
                    }
                }
            }
        }

        private void btnUseWith_Click(object sender, EventArgs e) //This will use an item from each side and see if it does anything.
        {
            if (Running)
            {
                if (playerObjects.SelectedItem != null && roomObjects.SelectedItem != null) //Make sure both lists have something selected
                { 
                    string useP = playerObjects.SelectedItem.ToString(); //Get both of them as strings.
                    string useR = roomObjects.SelectedItem.ToString();
                    if (useP.Equals("Small Box") && useR.Equals("Couch")) //These are for certain matches that might be found and will progress the game!
                    {
                        infoBox.Text = "You search under the couch and beneath the cushions for the key, and luckily find it!"
                            + " You then opened the box and found a hammer inside.";
                        Score += 5; //Increase score for correct actions
                        playerObjects.Items.Remove(useP); //Sometimes you lose an item...
                        playerObjects.Items.Add("Hammer"); //To gain an item
                    }
                    else if (useP.Equals("Hammer") && useR.Equals("Window"))
                    {
                        infoBox.Text = "You break the window with the hammer, getting glass everywhere!";
                        Score += 5;
                        roomObjects.Items.Remove(useR);
                        roomObjects.Items.Add("Window(Broken)");
                        roomObjects.Items.Add("Glass Shards");
                    }
                    else if (useP.Equals("Big Glass Shard") && useR.Equals("Couch"))
                    {
                        Score += 10;
                        infoBox.Text = "You slice open the recently patched up cushion like a crazy person, breaking the glass shard, and luckily find a small key!";
                        playerObjects.Items.Add("Small Key");
                        playerObjects.Items.Remove(useP);
                    }
                    else if (useP.Equals("Small Key") && useR.Equals("Front Door")) //Best Game Winning solution!
                    {
                        infoBox.Text = "You use the key on the padlock and luckily it fits, allowing you to quietly escape and get some help. The police manage to " +
                            "catch the person who kidnapped you as they were coming back to the apartment, so you not only escaped, you stopped this from happening again! You win!";
                        Score += 1000;
                        finish = true;
                        Running = false;
                        endGameToolStripMenuItem.Enabled = true;
                    }
                    else if (useP.Equals("Hammer") && useR.Equals("Window(Broken)"))
                    {
                        infoBox.Text = "You throw the hammer out the broken window. Why did you do that?";
                        Score -= 100;
                        playerObjects.Items.Remove(useP);
                    }
                    else if (useP.Equals("Hammer") && useR.Equals("Desk"))
                    {
                        infoBox.Text = "You use the claw part of the hammer on the desk drawer, and after a bit of work you pry it open." +
                            " Inside the now busted drawer you find a lighter!";
                        Score += 5;
                        roomObjects.Items.Remove("Desk");
                        roomObjects.Items.Add("Desk(Opened)");
                        playerObjects.Items.Add("Lighter");
                    }
                    else if (useP.Equals("Lighter") && useR.Equals("Bathroom"))
                    {
                        infoBox.Text = "You light the lighter and enter the bathroom, now able to see just enough to look around. It takes you a while "+
                            "but eventually you find a large key just before your lighter runs out of fuel and you leave the bathroom.";
                        Score += 5;
                        playerObjects.Items.Remove("Lighter");
                        playerObjects.Items.Add("Large Key");
                    }
                    else if (useP.Equals("Lighter") && useR.Equals("Couch")) //A game over can happen from the player's choices
                    {
                        infoBox.Text = "You set the couch on fire with the lighter, soon the whole room is on fire. Game Over";
                        Score -= 500; //Losing is still better than giving up, at least they tried!
                        Running = false;
                        endGameToolStripMenuItem.Enabled = true;
                    }
                    else if (useP.Equals("Lighter") && useR.Equals("Desk")) //A game over can happen from the player's choices
                    {
                        infoBox.Text = "You set the desk on fire with the lighter, soon the whole room is on fire. Game Over";
                        Score -= 500;
                        Running = false;
                        endGameToolStripMenuItem.Enabled = true;
                    }
                    else if (useP.Equals("Large Key") && useR.Equals("Old Trunk"))
                    {
                        infoBox.Text = "You use the key on the lock and open the trunk. Inside you find a bunch of random junk, including a Sledgehammer!";
                        Score += 5;
                        playerObjects.Items.Remove("Large Key");
                        playerObjects.Items.Add("Sledgehammer");
                    }
                    else if (useP.Equals("Sledgehammer") && useR.Equals("Front Door")) //Another game winning solution
                    {
                        infoBox.Text = "You begin breaking down the door with the sledgehammer. It takes a while, and makes a lot of noise, but it works! " +
                            "You escape outside just as cops arrive, guess someone called them from the noise you made. Sadly, whoever kidnapped you isn't back yet and " +
                            "seems to have escaped the area after seeing the cops, but you escaped at least! You win!";
                        Score += 500;
                        finish = true;
                        Running = false;
                        endGameToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        infoBox.Text = "Sorry, I don't think that will work.";
                        Score -= 2;
                    }
                }
            }
        }

        private void btnRoomInspect_Click(object sender, EventArgs e) //Inspect something in the room
        {
            if (Running)
            {
                if (roomObjects.SelectedIndex != -1)
                {
                    Score -= 1; //Lose a point
                    string inspect = roomObjects.SelectedItem.ToString(); //Get the item
                    MessageBox.Show(itemInspects[inspect]); //Show the message related to it.
                }
            }
        }

        private void btnPlayerInspect_Click(object sender, EventArgs e) //Inspect something the player is holding
        {
            if (Running)
            {
                if (playerObjects.SelectedIndex != -1)
                {
                    Score -= 1;
                    string inspect = playerObjects.SelectedItem.ToString();
                    MessageBox.Show(itemInspects[inspect]);
                }
            }
        }

        private void UploadScore() //Submit the score to the database
        {
            ScoreBoardDataSet.ScoreboardRow newScore = scoreBoardDataSet.Scoreboard.AddScoreboardRow(Guid.NewGuid(), initials, Score, finish, date); //Create a row object
            scoreboardTableAdapter.Update(newScore); //Update the table with the new row and save the database.
        }
    }
}
