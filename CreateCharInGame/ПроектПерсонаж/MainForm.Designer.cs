
namespace ПроектПерсонаж {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSila = new System.Windows.Forms.Label();
            this.labelLovkost = new System.Windows.Forms.Label();
            this.labelVinoslivost = new System.Windows.Forms.Label();
            this.labelMagiya = new System.Windows.Forms.Label();
            this.silaMinus = new System.Windows.Forms.Button();
            this.silaPlus = new System.Windows.Forms.Button();
            this.lovkostPlus = new System.Windows.Forms.Button();
            this.lovkostMinus = new System.Windows.Forms.Button();
            this.vinoslivostPlus = new System.Windows.Forms.Button();
            this.vinoslivostMinus = new System.Windows.Forms.Button();
            this.magiyPlus = new System.Windows.Forms.Button();
            this.magiyMinus = new System.Windows.Forms.Button();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя персонажа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(599, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите характеристики";
            // 
            // labelSila
            // 
            this.labelSila.AutoSize = true;
            this.labelSila.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSila.Location = new System.Drawing.Point(599, 100);
            this.labelSila.Name = "labelSila";
            this.labelSila.Size = new System.Drawing.Size(82, 30);
            this.labelSila.TabIndex = 3;
            this.labelSila.Text = "Сила: 0";
            // 
            // labelLovkost
            // 
            this.labelLovkost.AutoSize = true;
            this.labelLovkost.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLovkost.Location = new System.Drawing.Point(599, 142);
            this.labelLovkost.Name = "labelLovkost";
            this.labelLovkost.Size = new System.Drawing.Size(124, 30);
            this.labelLovkost.TabIndex = 4;
            this.labelLovkost.Text = "Ловкость: 0";
            // 
            // labelVinoslivost
            // 
            this.labelVinoslivost.AutoSize = true;
            this.labelVinoslivost.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVinoslivost.Location = new System.Drawing.Point(599, 179);
            this.labelVinoslivost.Name = "labelVinoslivost";
            this.labelVinoslivost.Size = new System.Drawing.Size(172, 30);
            this.labelVinoslivost.TabIndex = 5;
            this.labelVinoslivost.Text = "Выносливость: 0";
            // 
            // labelMagiya
            // 
            this.labelMagiya.AutoSize = true;
            this.labelMagiya.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMagiya.Location = new System.Drawing.Point(599, 221);
            this.labelMagiya.Name = "labelMagiya";
            this.labelMagiya.Size = new System.Drawing.Size(96, 30);
            this.labelMagiya.TabIndex = 6;
            this.labelMagiya.Text = "Магия: 0";
            // 
            // silaMinus
            // 
            this.silaMinus.Location = new System.Drawing.Point(785, 100);
            this.silaMinus.Name = "silaMinus";
            this.silaMinus.Size = new System.Drawing.Size(33, 23);
            this.silaMinus.TabIndex = 7;
            this.silaMinus.Text = "<";
            this.silaMinus.UseVisualStyleBackColor = true;
            this.silaMinus.Click += new System.EventHandler(this.silaMinus_Click);
            // 
            // silaPlus
            // 
            this.silaPlus.Location = new System.Drawing.Point(824, 100);
            this.silaPlus.Name = "silaPlus";
            this.silaPlus.Size = new System.Drawing.Size(33, 23);
            this.silaPlus.TabIndex = 8;
            this.silaPlus.Text = ">";
            this.silaPlus.UseVisualStyleBackColor = true;
            this.silaPlus.Click += new System.EventHandler(this.silaPlus_Click);
            // 
            // lovkostPlus
            // 
            this.lovkostPlus.Location = new System.Drawing.Point(824, 142);
            this.lovkostPlus.Name = "lovkostPlus";
            this.lovkostPlus.Size = new System.Drawing.Size(33, 23);
            this.lovkostPlus.TabIndex = 10;
            this.lovkostPlus.Text = ">";
            this.lovkostPlus.UseVisualStyleBackColor = true;
            this.lovkostPlus.Click += new System.EventHandler(this.lovkostPlus_Click);
            // 
            // lovkostMinus
            // 
            this.lovkostMinus.Location = new System.Drawing.Point(785, 142);
            this.lovkostMinus.Name = "lovkostMinus";
            this.lovkostMinus.Size = new System.Drawing.Size(33, 23);
            this.lovkostMinus.TabIndex = 9;
            this.lovkostMinus.Text = "<";
            this.lovkostMinus.UseVisualStyleBackColor = true;
            this.lovkostMinus.Click += new System.EventHandler(this.lovkostMinus_Click);
            // 
            // vinoslivostPlus
            // 
            this.vinoslivostPlus.Location = new System.Drawing.Point(824, 186);
            this.vinoslivostPlus.Name = "vinoslivostPlus";
            this.vinoslivostPlus.Size = new System.Drawing.Size(33, 23);
            this.vinoslivostPlus.TabIndex = 12;
            this.vinoslivostPlus.Text = ">";
            this.vinoslivostPlus.UseVisualStyleBackColor = true;
            this.vinoslivostPlus.Click += new System.EventHandler(this.vinoslivostPlus_Click);
            // 
            // vinoslivostMinus
            // 
            this.vinoslivostMinus.Location = new System.Drawing.Point(785, 186);
            this.vinoslivostMinus.Name = "vinoslivostMinus";
            this.vinoslivostMinus.Size = new System.Drawing.Size(33, 23);
            this.vinoslivostMinus.TabIndex = 11;
            this.vinoslivostMinus.Text = "<";
            this.vinoslivostMinus.UseVisualStyleBackColor = true;
            this.vinoslivostMinus.Click += new System.EventHandler(this.vinoslivostMinus_Click);
            // 
            // magiyPlus
            // 
            this.magiyPlus.Location = new System.Drawing.Point(824, 233);
            this.magiyPlus.Name = "magiyPlus";
            this.magiyPlus.Size = new System.Drawing.Size(33, 23);
            this.magiyPlus.TabIndex = 14;
            this.magiyPlus.Text = ">";
            this.magiyPlus.UseVisualStyleBackColor = true;
            this.magiyPlus.Click += new System.EventHandler(this.magiyPlus_Click);
            // 
            // magiyMinus
            // 
            this.magiyMinus.Location = new System.Drawing.Point(785, 233);
            this.magiyMinus.Name = "magiyMinus";
            this.magiyMinus.Size = new System.Drawing.Size(33, 23);
            this.magiyMinus.TabIndex = 13;
            this.magiyMinus.Text = "<";
            this.magiyMinus.UseVisualStyleBackColor = true;
            this.magiyMinus.Click += new System.EventHandler(this.magiyMinus_Click);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(600, 284);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(261, 24);
            this.labelPoints.TabIndex = 15;
            this.labelPoints.Text = "Общее количество очков: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 50);
            this.label3.TabIndex = 16;
            this.label3.Text = "Создание персонажа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Выберите аватар";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DK.png");
            this.imageList1.Images.SetKeyName(1, "druid.png");
            this.imageList1.Images.SetKeyName(2, "hunter.png");
            this.imageList1.Images.SetKeyName(3, "lock.png");
            this.imageList1.Images.SetKeyName(4, "mage.png");
            this.imageList1.Images.SetKeyName(5, "monk.png");
            this.imageList1.Images.SetKeyName(6, "paladin.png");
            this.imageList1.Images.SetKeyName(7, "priest.png");
            this.imageList1.Images.SetKeyName(8, "rogue.png");
            this.imageList1.Images.SetKeyName(9, "shaman.png");
            this.imageList1.Images.SetKeyName(10, "warrior.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(12, 473);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 19;
            this.previous.Text = "<-";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(227, 473);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 20;
            this.next.Text = "->";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(49, 525);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(229, 59);
            this.resume.TabIndex = 21;
            this.resume.Text = "Продолжить";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.TextChanged += new System.EventHandler(this.resume_TextChanged);
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 596);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.magiyPlus);
            this.Controls.Add(this.magiyMinus);
            this.Controls.Add(this.vinoslivostPlus);
            this.Controls.Add(this.vinoslivostMinus);
            this.Controls.Add(this.lovkostPlus);
            this.Controls.Add(this.lovkostMinus);
            this.Controls.Add(this.silaPlus);
            this.Controls.Add(this.silaMinus);
            this.Controls.Add(this.labelMagiya);
            this.Controls.Add(this.labelVinoslivost);
            this.Controls.Add(this.labelLovkost);
            this.Controls.Add(this.labelSila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSila;
        private System.Windows.Forms.Label labelLovkost;
        private System.Windows.Forms.Label labelVinoslivost;
        private System.Windows.Forms.Label labelMagiya;
        private System.Windows.Forms.Button silaMinus;
        private System.Windows.Forms.Button silaPlus;
        private System.Windows.Forms.Button lovkostPlus;
        private System.Windows.Forms.Button lovkostMinus;
        private System.Windows.Forms.Button vinoslivostPlus;
        private System.Windows.Forms.Button vinoslivostMinus;
        private System.Windows.Forms.Button magiyPlus;
        private System.Windows.Forms.Button magiyMinus;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button resume;
    }
}

