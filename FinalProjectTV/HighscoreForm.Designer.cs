namespace FinalProjectTV
{
    partial class HighscoreForm
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
            this.gameInfoDataSet = new FinalProjectTV.GameInfoDataSet();
            this.scoreboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreboardTableAdapter = new FinalProjectTV.GameInfoDataSetTableAdapters.ScoreboardTableAdapter();
            this.tableAdapterManager = new FinalProjectTV.GameInfoDataSetTableAdapters.TableAdapterManager();
            this.scoreboardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInitials = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameInfoDataSet
            // 
            this.gameInfoDataSet.DataSetName = "GameInfoDataSet";
            this.gameInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreboardBindingSource
            // 
            this.scoreboardBindingSource.DataMember = "Scoreboard";
            this.scoreboardBindingSource.DataSource = this.gameInfoDataSet;
            // 
            // scoreboardTableAdapter
            // 
            this.scoreboardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = FinalProjectTV.GameInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scoreboardDataGridView
            // 
            this.scoreboardDataGridView.AutoGenerateColumns = false;
            this.scoreboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreboardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.scoreboardDataGridView.DataSource = this.scoreboardBindingSource;
            this.scoreboardDataGridView.Location = new System.Drawing.Point(12, 12);
            this.scoreboardDataGridView.Name = "scoreboardDataGridView";
            this.scoreboardDataGridView.Size = new System.Drawing.Size(443, 355);
            this.scoreboardDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Initials";
            this.dataGridViewTextBoxColumn1.HeaderText = "Initials";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Finished";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Finished";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnInitials
            // 
            this.btnInitials.Location = new System.Drawing.Point(13, 397);
            this.btnInitials.Name = "btnInitials";
            this.btnInitials.Size = new System.Drawing.Size(75, 23);
            this.btnInitials.TabIndex = 1;
            this.btnInitials.Text = "Initials";
            this.btnInitials.UseVisualStyleBackColor = true;
            this.btnInitials.Click += new System.EventHandler(this.btnInitials_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(131, 397);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(75, 23);
            this.btnScore.TabIndex = 2;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(258, 397);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 3;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(380, 397);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(190, 370);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(80, 13);
            this.lblSort.TabIndex = 5;
            this.lblSort.Text = "Sorting options:";
            // 
            // HighscoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 432);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnInitials);
            this.Controls.Add(this.scoreboardDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighscoreForm";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.HighscoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameInfoDataSet gameInfoDataSet;
        private System.Windows.Forms.BindingSource scoreboardBindingSource;
        private GameInfoDataSetTableAdapters.ScoreboardTableAdapter scoreboardTableAdapter;
        private GameInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView scoreboardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnInitials;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Label lblSort;
    }
}