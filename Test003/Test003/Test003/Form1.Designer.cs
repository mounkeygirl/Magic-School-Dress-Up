namespace Test003
{
    partial class Form1
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
            this.outputLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.eventAlertPanel = new System.Windows.Forms.Panel();
            this.eventOutputLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOptionBox = new System.Windows.Forms.FlowLayoutPanel();
            this.multipleChoiceABtn = new System.Windows.Forms.Button();
            this.multipleChoiceBBtn = new System.Windows.Forms.Button();
            this.multipleChoiceCBtn = new System.Windows.Forms.Button();
            this.stage = new System.Windows.Forms.Panel();
            this.middleCharacterBoxImage = new System.Windows.Forms.PictureBox();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.foregroundImage = new System.Windows.Forms.PictureBox();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.eventAlertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonOptionBox.SuspendLayout();
            this.stage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.middleCharacterBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputLbl.Location = new System.Drawing.Point(22, 447);
            this.outputLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(677, 156);
            this.outputLbl.TabIndex = 0;
            this.outputLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(722, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.prevButton);
            this.flowLayoutPanel1.Controls.Add(this.nextBtn);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(414, 605);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 51);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(251)))));
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.prevButton.Location = new System.Drawing.Point(2, 2);
            this.prevButton.Margin = new System.Windows.Forms.Padding(2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(138, 43);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(251)))));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nextBtn.Location = new System.Drawing.Point(144, 2);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(127, 43);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // eventAlertPanel
            // 
            this.eventAlertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventAlertPanel.Controls.Add(this.eventOutputLbl);
            this.eventAlertPanel.Controls.Add(this.pictureBox1);
            this.eventAlertPanel.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventAlertPanel.ForeColor = System.Drawing.Color.White;
            this.eventAlertPanel.Location = new System.Drawing.Point(217, 119);
            this.eventAlertPanel.Name = "eventAlertPanel";
            this.eventAlertPanel.Size = new System.Drawing.Size(277, 223);
            this.eventAlertPanel.TabIndex = 7;
            this.eventAlertPanel.Visible = false;
            this.eventAlertPanel.Click += new System.EventHandler(this.eventAlertPanel_Click);
            // 
            // eventOutputLbl
            // 
            this.eventOutputLbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.eventOutputLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventOutputLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventOutputLbl.Location = new System.Drawing.Point(0, 124);
            this.eventOutputLbl.Name = "eventOutputLbl";
            this.eventOutputLbl.Size = new System.Drawing.Size(275, 97);
            this.eventOutputLbl.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Test003.Properties.Resources.mushrooms001;
            this.pictureBox1.Location = new System.Drawing.Point(51, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOptionBox
            // 
            this.buttonOptionBox.Controls.Add(this.multipleChoiceABtn);
            this.buttonOptionBox.Controls.Add(this.multipleChoiceBBtn);
            this.buttonOptionBox.Controls.Add(this.multipleChoiceCBtn);
            this.buttonOptionBox.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptionBox.Location = new System.Drawing.Point(128, 29);
            this.buttonOptionBox.Name = "buttonOptionBox";
            this.buttonOptionBox.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.buttonOptionBox.Size = new System.Drawing.Size(479, 294);
            this.buttonOptionBox.TabIndex = 9;
            this.buttonOptionBox.Visible = false;
            // 
            // multipleChoiceABtn
            // 
            this.multipleChoiceABtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(251)))));
            this.multipleChoiceABtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multipleChoiceABtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.multipleChoiceABtn.Location = new System.Drawing.Point(23, 8);
            this.multipleChoiceABtn.Name = "multipleChoiceABtn";
            this.multipleChoiceABtn.Size = new System.Drawing.Size(440, 85);
            this.multipleChoiceABtn.TabIndex = 0;
            this.multipleChoiceABtn.Text = "button1";
            this.multipleChoiceABtn.UseVisualStyleBackColor = false;
            this.multipleChoiceABtn.Click += new System.EventHandler(this.multipleChoiceABtn_Click);
            // 
            // multipleChoiceBBtn
            // 
            this.multipleChoiceBBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(251)))));
            this.multipleChoiceBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multipleChoiceBBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.multipleChoiceBBtn.Location = new System.Drawing.Point(23, 99);
            this.multipleChoiceBBtn.Name = "multipleChoiceBBtn";
            this.multipleChoiceBBtn.Size = new System.Drawing.Size(440, 85);
            this.multipleChoiceBBtn.TabIndex = 1;
            this.multipleChoiceBBtn.Text = "button2";
            this.multipleChoiceBBtn.UseVisualStyleBackColor = false;
            this.multipleChoiceBBtn.Click += new System.EventHandler(this.multipleChoiceBBtn_Click);
            // 
            // multipleChoiceCBtn
            // 
            this.multipleChoiceCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(251)))));
            this.multipleChoiceCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multipleChoiceCBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.multipleChoiceCBtn.Location = new System.Drawing.Point(23, 190);
            this.multipleChoiceCBtn.Name = "multipleChoiceCBtn";
            this.multipleChoiceCBtn.Size = new System.Drawing.Size(440, 85);
            this.multipleChoiceCBtn.TabIndex = 2;
            this.multipleChoiceCBtn.Text = "button3";
            this.multipleChoiceCBtn.UseVisualStyleBackColor = false;
            this.multipleChoiceCBtn.Click += new System.EventHandler(this.multipleChoiceCBtn_Click);
            // 
            // stage
            // 
            this.stage.Controls.Add(this.middleCharacterBoxImage);
            this.stage.Controls.Add(this.buttonOptionBox);
            this.stage.Controls.Add(this.backgroundImage);
            this.stage.Controls.Add(this.foregroundImage);
            this.stage.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage.ForeColor = System.Drawing.Color.LemonChiffon;
            this.stage.Location = new System.Drawing.Point(0, 33);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(722, 411);
            this.stage.TabIndex = 10;
            // 
            // middleCharacterBoxImage
            // 
            this.middleCharacterBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.middleCharacterBoxImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.middleCharacterBoxImage.Image = global::Test003.Properties.Resources.farmerMother001;
            this.middleCharacterBoxImage.Location = new System.Drawing.Point(0, 55);
            this.middleCharacterBoxImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.middleCharacterBoxImage.Name = "middleCharacterBoxImage";
            this.middleCharacterBoxImage.Size = new System.Drawing.Size(722, 356);
            this.middleCharacterBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middleCharacterBoxImage.TabIndex = 3;
            this.middleCharacterBoxImage.TabStop = false;
            this.middleCharacterBoxImage.Click += new System.EventHandler(this.middleCharacterBoxImage_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundImage.Image = global::Test003.Properties.Resources.PumpkinFarm001;
            this.backgroundImage.Location = new System.Drawing.Point(0, 0);
            this.backgroundImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(722, 411);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundImage.TabIndex = 2;
            this.backgroundImage.TabStop = false;
            this.backgroundImage.Click += new System.EventHandler(this.backgroundImage_Click);
            // 
            // foregroundImage
            // 
            this.foregroundImage.BackColor = System.Drawing.Color.Transparent;
            this.foregroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foregroundImage.Image = global::Test003.Properties.Resources.FarmerFamilyGroupScene;
            this.foregroundImage.Location = new System.Drawing.Point(0, 0);
            this.foregroundImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.foregroundImage.Name = "foregroundImage";
            this.foregroundImage.Size = new System.Drawing.Size(722, 411);
            this.foregroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foregroundImage.TabIndex = 8;
            this.foregroundImage.TabStop = false;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(722, 664);
            this.Controls.Add(this.stage);
            this.Controls.Add(this.eventAlertPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.eventAlertPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonOptionBox.ResumeLayout(false);
            this.stage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.middleCharacterBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.PictureBox middleCharacterBoxImage;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel eventAlertPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventOutputLbl;
        private System.Windows.Forms.PictureBox foregroundImage;
        private System.Windows.Forms.FlowLayoutPanel buttonOptionBox;
        private System.Windows.Forms.Button multipleChoiceABtn;
        private System.Windows.Forms.Button multipleChoiceBBtn;
        private System.Windows.Forms.Button multipleChoiceCBtn;
        private System.Windows.Forms.Panel stage;
        private System.Windows.Forms.Timer loadingTimer;
    }
}

