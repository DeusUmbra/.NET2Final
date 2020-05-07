namespace FinalProjectTV
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerObjects = new System.Windows.Forms.ListBox();
            this.roomObjects = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayerInspect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRoomUse = new System.Windows.Forms.Button();
            this.btnRoomInspect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUseWith = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.scoreBoardDataSet = new FinalProjectTV.ScoreBoardDataSet();
            this.scoreboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreboardTableAdapter = new FinalProjectTV.ScoreBoardDataSetTableAdapters.ScoreboardTableAdapter();
            this.tableAdapterManager = new FinalProjectTV.ScoreBoardDataSetTableAdapters.TableAdapterManager();
            this.btnPlayerUse = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.Location = new System.Drawing.Point(12, 280);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.infoBox.Size = new System.Drawing.Size(434, 182);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "Welcome Player! Are you ready to play? Just click New Game! Want to see some High" +
    "scores? Just click Highscores! Confused? Click About!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.endGameToolStripMenuItem,
            this.highscoresToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Enabled = false;
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            this.highscoresToolStripMenuItem.Click += new System.EventHandler(this.highscoresToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // playerObjects
            // 
            this.playerObjects.FormattingEnabled = true;
            this.playerObjects.Location = new System.Drawing.Point(3, 92);
            this.playerObjects.Name = "playerObjects";
            this.playerObjects.Size = new System.Drawing.Size(120, 147);
            this.playerObjects.TabIndex = 2;
            // 
            // roomObjects
            // 
            this.roomObjects.FormattingEnabled = true;
            this.roomObjects.Location = new System.Drawing.Point(3, 92);
            this.roomObjects.Name = "roomObjects";
            this.roomObjects.Size = new System.Drawing.Size(120, 147);
            this.roomObjects.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPlayerInspect);
            this.panel1.Controls.Add(this.btnPlayerUse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.playerObjects);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 246);
            this.panel1.TabIndex = 4;
            // 
            // btnPlayerInspect
            // 
            this.btnPlayerInspect.Location = new System.Drawing.Point(24, 34);
            this.btnPlayerInspect.Name = "btnPlayerInspect";
            this.btnPlayerInspect.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerInspect.TabIndex = 5;
            this.btnPlayerInspect.Text = "Inspect";
            this.btnPlayerInspect.UseVisualStyleBackColor = true;
            this.btnPlayerInspect.Click += new System.EventHandler(this.btnPlayerInspect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRoomUse);
            this.panel2.Controls.Add(this.btnRoomInspect);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.roomObjects);
            this.panel2.Location = new System.Drawing.Point(316, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 246);
            this.panel2.TabIndex = 5;
            // 
            // btnRoomUse
            // 
            this.btnRoomUse.Location = new System.Drawing.Point(28, 63);
            this.btnRoomUse.Name = "btnRoomUse";
            this.btnRoomUse.Size = new System.Drawing.Size(75, 23);
            this.btnRoomUse.TabIndex = 6;
            this.btnRoomUse.Text = "Use/Pick up";
            this.btnRoomUse.UseVisualStyleBackColor = true;
            this.btnRoomUse.Click += new System.EventHandler(this.btnRoomUse_Click);
            // 
            // btnRoomInspect
            // 
            this.btnRoomInspect.Location = new System.Drawing.Point(28, 34);
            this.btnRoomInspect.Name = "btnRoomInspect";
            this.btnRoomInspect.Size = new System.Drawing.Size(75, 23);
            this.btnRoomInspect.TabIndex = 6;
            this.btnRoomInspect.Text = "Inspect";
            this.btnRoomInspect.UseVisualStyleBackColor = true;
            this.btnRoomInspect.Click += new System.EventHandler(this.btnRoomInspect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room";
            // 
            // btnUseWith
            // 
            this.btnUseWith.Location = new System.Drawing.Point(189, 121);
            this.btnUseWith.Name = "btnUseWith";
            this.btnUseWith.Size = new System.Drawing.Size(75, 23);
            this.btnUseWith.TabIndex = 6;
            this.btnUseWith.Text = "Use With";
            this.btnUseWith.UseVisualStyleBackColor = true;
            this.btnUseWith.Click += new System.EventHandler(this.btnUseWith_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(148, 126);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(25, 13);
            this.lblLeft.TabIndex = 7;
            this.lblLeft.Text = "<----";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(285, 126);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(25, 13);
            this.lblRight.TabIndex = 8;
            this.lblRight.Text = "---->";
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnGiveUp.Image")));
            this.btnGiveUp.Location = new System.Drawing.Point(172, 33);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(113, 53);
            this.btnGiveUp.TabIndex = 9;
            this.btnGiveUp.Text = "I Give Up";
            this.btnGiveUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(189, 193);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(75, 23);
            this.btnHint.TabIndex = 10;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // scoreBoardDataSet
            // 
            this.scoreBoardDataSet.DataSetName = "ScoreBoardDataSet";
            this.scoreBoardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreboardBindingSource
            // 
            this.scoreboardBindingSource.DataMember = "Scoreboard";
            this.scoreboardBindingSource.DataSource = this.scoreBoardDataSet;
            // 
            // scoreboardTableAdapter
            // 
            this.scoreboardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScoreboardTableAdapter = this.scoreboardTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProjectTV.ScoreBoardDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnPlayerUse
            // 
            this.btnPlayerUse.Location = new System.Drawing.Point(24, 63);
            this.btnPlayerUse.Name = "btnPlayerUse";
            this.btnPlayerUse.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerUse.TabIndex = 4;
            this.btnPlayerUse.Text = "Use";
            this.btnPlayerUse.UseVisualStyleBackColor = true;
            this.btnPlayerUse.Click += new System.EventHandler(this.btnPlayerUse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 482);
            this.ControlBox = false;
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.btnUseWith);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox playerObjects;
        private System.Windows.Forms.ListBox roomObjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayerInspect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRoomUse;
        private System.Windows.Forms.Button btnRoomInspect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUseWith;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnHint;
        private ScoreBoardDataSet scoreBoardDataSet;
        private System.Windows.Forms.BindingSource scoreboardBindingSource;
        private ScoreBoardDataSetTableAdapters.ScoreboardTableAdapter scoreboardTableAdapter;
        private ScoreBoardDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnPlayerUse;
    }
}

