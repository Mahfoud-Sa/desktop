namespace سطح_المكتب
{
    partial class TaskManager
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
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonKill = new System.Windows.Forms.Button();
            this.buttonStartProcess = new System.Windows.Forms.Button();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxDestinationFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Des_Brows = new System.Windows.Forms.Button();
            this.Sou_Brows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.BackColor = System.Drawing.Color.White;
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(12, 45);
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(776, 315);
            this.listViewProcesses.TabIndex = 51;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            this.listViewProcesses.SelectedIndexChanged += new System.EventHandler(this.listViewProcesses_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 248;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(631, 376);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 50;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Running Process";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 382);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 48;
            this.label16.Text = "Process Name";
            // 
            // buttonKill
            // 
            this.buttonKill.BackColor = System.Drawing.Color.Transparent;
            this.buttonKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKill.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKill.Location = new System.Drawing.Point(712, 376);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(75, 23);
            this.buttonKill.TabIndex = 47;
            this.buttonKill.Text = "Kill process";
            this.buttonKill.UseVisualStyleBackColor = false;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click_1);
            // 
            // buttonStartProcess
            // 
            this.buttonStartProcess.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartProcess.Location = new System.Drawing.Point(292, 382);
            this.buttonStartProcess.Name = "buttonStartProcess";
            this.buttonStartProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonStartProcess.TabIndex = 46;
            this.buttonStartProcess.Text = "START";
            this.buttonStartProcess.UseVisualStyleBackColor = false;
            this.buttonStartProcess.Click += new System.EventHandler(this.buttonStartProcess_Click_1);
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.BackColor = System.Drawing.Color.White;
            this.textBoxProcessName.Location = new System.Drawing.Point(130, 382);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(146, 20);
            this.textBoxProcessName.TabIndex = 45;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(189, 623);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(146, 30);
            this.buttonCopy.TabIndex = 52;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Source File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(29, 489);
            this.textBoxSourceFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(273, 20);
            this.textBoxSourceFile.TabIndex = 54;
            this.textBoxSourceFile.TextChanged += new System.EventHandler(this.textBoxSourceFile_TextChanged);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.Transparent;
            this.buttonCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCut.Location = new System.Drawing.Point(189, 575);
            this.buttonCut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(147, 30);
            this.buttonCut.TabIndex = 55;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(27, 623);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 30);
            this.buttonDelete.TabIndex = 56;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(26, 575);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(147, 30);
            this.buttonCreate.TabIndex = 57;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click_1);
            // 
            // textBoxDestinationFile
            // 
            this.textBoxDestinationFile.BackColor = System.Drawing.Color.White;
            this.textBoxDestinationFile.Location = new System.Drawing.Point(29, 537);
            this.textBoxDestinationFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDestinationFile.Name = "textBoxDestinationFile";
            this.textBoxDestinationFile.Size = new System.Drawing.Size(273, 20);
            this.textBoxDestinationFile.TabIndex = 58;
            this.textBoxDestinationFile.TextChanged += new System.EventHandler(this.textBoxDestinationFile_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Destination File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Des_Brows
            // 
            this.Des_Brows.FlatAppearance.BorderSize = 0;
            this.Des_Brows.Location = new System.Drawing.Point(308, 535);
            this.Des_Brows.Name = "Des_Brows";
            this.Des_Brows.Size = new System.Drawing.Size(28, 23);
            this.Des_Brows.TabIndex = 60;
            this.Des_Brows.Text = "...";
            this.Des_Brows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Des_Brows.UseVisualStyleBackColor = true;
            this.Des_Brows.Click += new System.EventHandler(this.Des_Brows_Click_1);
            // 
            // Sou_Brows
            // 
            this.Sou_Brows.FlatAppearance.BorderSize = 0;
            this.Sou_Brows.Location = new System.Drawing.Point(308, 489);
            this.Sou_Brows.Name = "Sou_Brows";
            this.Sou_Brows.Size = new System.Drawing.Size(28, 20);
            this.Sou_Brows.TabIndex = 61;
            this.Sou_Brows.Text = "...";
            this.Sou_Brows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sou_Brows.UseVisualStyleBackColor = true;
            this.Sou_Brows.Click += new System.EventHandler(this.Sou_Brows_Click_1);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSourceFile);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxDestinationFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Des_Brows);
            this.Controls.Add(this.Sou_Brows);
            this.Controls.Add(this.listViewProcesses);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonKill);
            this.Controls.Add(this.buttonStartProcess);
            this.Controls.Add(this.textBoxProcessName);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.Button buttonStartProcess;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxDestinationFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Des_Brows;
        private System.Windows.Forms.Button Sou_Brows;
    }
}