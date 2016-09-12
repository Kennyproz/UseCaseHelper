namespace Use_Cases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.rbUseCase = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbTeken = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.btClear = new System.Windows.Forms.Button();
            this.pbActorOne = new System.Windows.Forms.PictureBox();
            this.pbActorTwo = new System.Windows.Forms.PictureBox();
            this.pbActorThree = new System.Windows.Forms.PictureBox();
            this.lbActorOne = new System.Windows.Forms.Label();
            this.lbActorTwo = new System.Windows.Forms.Label();
            this.lbActorThree = new System.Windows.Forms.Label();
            this.lbActorName = new System.Windows.Forms.Label();
            this.tbActorName = new System.Windows.Forms.TextBox();
            this.lbUseCaseName = new System.Windows.Forms.Label();
            this.tbUseCaseName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeken)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActorOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActorTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActorThree)).BeginInit();
            this.SuspendLayout();
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(9, 17);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(50, 17);
            this.rbActor.TabIndex = 0;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // rbUseCase
            // 
            this.rbUseCase.AutoSize = true;
            this.rbUseCase.Location = new System.Drawing.Point(9, 40);
            this.rbUseCase.Name = "rbUseCase";
            this.rbUseCase.Size = new System.Drawing.Size(70, 17);
            this.rbUseCase.TabIndex = 1;
            this.rbUseCase.TabStop = true;
            this.rbUseCase.Text = "Use case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(9, 63);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUseCase);
            this.groupBox1.Controls.Add(this.rbActor);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbTeken
            // 
            this.pbTeken.BackColor = System.Drawing.Color.White;
            this.pbTeken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeken.Location = new System.Drawing.Point(16, 140);
            this.pbTeken.Name = "pbTeken";
            this.pbTeken.Size = new System.Drawing.Size(532, 478);
            this.pbTeken.TabIndex = 4;
            this.pbTeken.TabStop = false;
            this.pbTeken.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTeken_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEdit);
            this.groupBox2.Controls.Add(this.rbRemove);
            this.groupBox2.Controls.Add(this.rbAdd);
            this.groupBox2.Location = new System.Drawing.Point(157, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modus";
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Location = new System.Drawing.Point(11, 40);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(43, 17);
            this.rbEdit.TabIndex = 2;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "Edit";
            this.rbEdit.UseVisualStyleBackColor = true;
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.Location = new System.Drawing.Point(11, 63);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(65, 17);
            this.rbRemove.TabIndex = 1;
            this.rbRemove.TabStop = true;
            this.rbRemove.Text = "Remove";
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(11, 17);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(342, 84);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(107, 23);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear All Usecases\r\n";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbActorOne
            // 
            this.pbActorOne.Image = ((System.Drawing.Image)(resources.GetObject("pbActorOne.Image")));
            this.pbActorOne.Location = new System.Drawing.Point(32, 178);
            this.pbActorOne.Name = "pbActorOne";
            this.pbActorOne.Size = new System.Drawing.Size(73, 109);
            this.pbActorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActorOne.TabIndex = 7;
            this.pbActorOne.TabStop = false;
            // 
            // pbActorTwo
            // 
            this.pbActorTwo.Image = ((System.Drawing.Image)(resources.GetObject("pbActorTwo.Image")));
            this.pbActorTwo.Location = new System.Drawing.Point(32, 323);
            this.pbActorTwo.Name = "pbActorTwo";
            this.pbActorTwo.Size = new System.Drawing.Size(73, 109);
            this.pbActorTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActorTwo.TabIndex = 8;
            this.pbActorTwo.TabStop = false;
            // 
            // pbActorThree
            // 
            this.pbActorThree.Image = ((System.Drawing.Image)(resources.GetObject("pbActorThree.Image")));
            this.pbActorThree.Location = new System.Drawing.Point(32, 468);
            this.pbActorThree.Name = "pbActorThree";
            this.pbActorThree.Size = new System.Drawing.Size(73, 109);
            this.pbActorThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActorThree.TabIndex = 9;
            this.pbActorThree.TabStop = false;
            // 
            // lbActorOne
            // 
            this.lbActorOne.AutoSize = true;
            this.lbActorOne.BackColor = System.Drawing.Color.White;
            this.lbActorOne.Location = new System.Drawing.Point(50, 290);
            this.lbActorOne.Name = "lbActorOne";
            this.lbActorOne.Size = new System.Drawing.Size(0, 13);
            this.lbActorOne.TabIndex = 10;
            // 
            // lbActorTwo
            // 
            this.lbActorTwo.AutoSize = true;
            this.lbActorTwo.BackColor = System.Drawing.Color.White;
            this.lbActorTwo.Location = new System.Drawing.Point(50, 435);
            this.lbActorTwo.Name = "lbActorTwo";
            this.lbActorTwo.Size = new System.Drawing.Size(0, 13);
            this.lbActorTwo.TabIndex = 11;
            // 
            // lbActorThree
            // 
            this.lbActorThree.AutoSize = true;
            this.lbActorThree.BackColor = System.Drawing.Color.White;
            this.lbActorThree.Location = new System.Drawing.Point(50, 580);
            this.lbActorThree.Name = "lbActorThree";
            this.lbActorThree.Size = new System.Drawing.Size(0, 13);
            this.lbActorThree.TabIndex = 12;
            // 
            // lbActorName
            // 
            this.lbActorName.AutoSize = true;
            this.lbActorName.Location = new System.Drawing.Point(279, 24);
            this.lbActorName.Name = "lbActorName";
            this.lbActorName.Size = new System.Drawing.Size(64, 13);
            this.lbActorName.TabIndex = 13;
            this.lbActorName.Text = "Actor name:";
            // 
            // tbActorName
            // 
            this.tbActorName.Location = new System.Drawing.Point(349, 21);
            this.tbActorName.Name = "tbActorName";
            this.tbActorName.Size = new System.Drawing.Size(100, 20);
            this.tbActorName.TabIndex = 14;
            // 
            // lbUseCaseName
            // 
            this.lbUseCaseName.AutoSize = true;
            this.lbUseCaseName.Location = new System.Drawing.Point(279, 53);
            this.lbUseCaseName.Name = "lbUseCaseName";
            this.lbUseCaseName.Size = new System.Drawing.Size(56, 13);
            this.lbUseCaseName.TabIndex = 17;
            this.lbUseCaseName.Text = "Use Case:";
            // 
            // tbUseCaseName
            // 
            this.tbUseCaseName.Location = new System.Drawing.Point(349, 50);
            this.tbUseCaseName.Name = "tbUseCaseName";
            this.tbUseCaseName.Size = new System.Drawing.Size(100, 20);
            this.tbUseCaseName.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(570, 633);
            this.Controls.Add(this.tbUseCaseName);
            this.Controls.Add(this.lbUseCaseName);
            this.Controls.Add(this.tbActorName);
            this.Controls.Add(this.lbActorName);
            this.Controls.Add(this.lbActorThree);
            this.Controls.Add(this.lbActorTwo);
            this.Controls.Add(this.lbActorOne);
            this.Controls.Add(this.pbActorThree);
            this.Controls.Add(this.pbActorTwo);
            this.Controls.Add(this.pbActorOne);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbTeken);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User Case Helper Ken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeken)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActorOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActorTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActorThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbActor;
        private System.Windows.Forms.RadioButton rbUseCase;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbTeken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.PictureBox pbActorOne;
        private System.Windows.Forms.PictureBox pbActorTwo;
        private System.Windows.Forms.PictureBox pbActorThree;
        private System.Windows.Forms.Label lbActorOne;
        private System.Windows.Forms.Label lbActorTwo;
        private System.Windows.Forms.Label lbActorThree;
        private System.Windows.Forms.Label lbActorName;
        private System.Windows.Forms.TextBox tbActorName;
        private System.Windows.Forms.Label lbUseCaseName;
        private System.Windows.Forms.TextBox tbUseCaseName;
        private System.Windows.Forms.RadioButton rbEdit;
    }
}

