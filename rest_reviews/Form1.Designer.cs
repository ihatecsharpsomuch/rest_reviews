namespace rest_reviews
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.login_button = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.star_ch = new System.Windows.Forms.Label();
            this.date_cho = new System.Windows.Forms.DateTimePicker();
            this.date_att = new System.Windows.Forms.Label();
            this.text_rev = new System.Windows.Forms.Label();
            this.stars_cho = new System.Windows.Forms.ComboBox();
            this.publish_button = new System.Windows.Forms.Button();
            this.rev_text = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.rest_info = new System.Windows.Forms.Label();
            this.rest_cho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restid_cho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(568, 6);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(107, 38);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "American",
            "Asian",
            "Bangladeshi",
            "Breakfast",
            "British",
            "Burgers",
            "Burritos",
            "Cafe",
            "Caribbean",
            "Chicken",
            "Chinese",
            "Coffee",
            "Curry",
            "Desserts",
            "Fish and Chips",
            "Groceries",
            "Halal",
            "Ice Cream",
            "Indian",
            "Italian",
            "Japanese",
            "Kebab",
            "Korean",
            "Lebanese",
            "Mexican",
            "Middle Eastern",
            "Milkshakes",
            "Nepalese",
            "Oriental",
            "Pancakes",
            "Pasta",
            "Pizza",
            "Pub Food",
            "Sandwiches",
            "Steak",
            "Street Food",
            "Sushi",
            "Tapas",
            "Thai",
            "Turkish",
            "Waffles"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 47);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(278, 740);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(12, 12);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(278, 26);
            this.username_input.TabIndex = 7;
            this.username_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(296, 12);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(266, 26);
            this.password_input.TabIndex = 8;
            this.password_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // star_ch
            // 
            this.star_ch.AutoSize = true;
            this.star_ch.Location = new System.Drawing.Point(883, 158);
            this.star_ch.Name = "star_ch";
            this.star_ch.Size = new System.Drawing.Size(61, 20);
            this.star_ch.TabIndex = 17;
            this.star_ch.Text = "Star(s):";
            this.star_ch.Click += new System.EventHandler(this.star_ch_Click);
            // 
            // date_cho
            // 
            this.date_cho.Location = new System.Drawing.Point(1030, 122);
            this.date_cho.MaxDate = new System.DateTime(2024, 2, 23, 0, 0, 0, 0);
            this.date_cho.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.date_cho.Name = "date_cho";
            this.date_cho.Size = new System.Drawing.Size(288, 26);
            this.date_cho.TabIndex = 18;
            this.date_cho.Value = new System.DateTime(2023, 12, 14, 0, 0, 0, 0);
            this.date_cho.ValueChanged += new System.EventHandler(this.date_cho_ValueChanged);
            // 
            // date_att
            // 
            this.date_att.AutoSize = true;
            this.date_att.Location = new System.Drawing.Point(883, 127);
            this.date_att.Name = "date_att";
            this.date_att.Size = new System.Drawing.Size(120, 20);
            this.date_att.TabIndex = 19;
            this.date_att.Text = "Date attended: ";
            // 
            // text_rev
            // 
            this.text_rev.AutoSize = true;
            this.text_rev.Location = new System.Drawing.Point(883, 212);
            this.text_rev.Name = "text_rev";
            this.text_rev.Size = new System.Drawing.Size(97, 40);
            this.text_rev.TabIndex = 20;
            this.text_rev.Text = "Add your\r\nreview here: ";
            // 
            // stars_cho
            // 
            this.stars_cho.FormattingEnabled = true;
            this.stars_cho.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.stars_cho.Location = new System.Drawing.Point(1030, 155);
            this.stars_cho.Name = "stars_cho";
            this.stars_cho.Size = new System.Drawing.Size(115, 28);
            this.stars_cho.TabIndex = 22;
            this.stars_cho.SelectedIndexChanged += new System.EventHandler(this.stars_cho_SelectedIndexChanged);
            // 
            // publish_button
            // 
            this.publish_button.Location = new System.Drawing.Point(1322, 47);
            this.publish_button.Name = "publish_button";
            this.publish_button.Size = new System.Drawing.Size(87, 28);
            this.publish_button.TabIndex = 23;
            this.publish_button.Text = "Publish";
            this.publish_button.UseVisualStyleBackColor = true;
            this.publish_button.Click += new System.EventHandler(this.publish_button_Click);
            // 
            // rev_text
            // 
            this.rev_text.Location = new System.Drawing.Point(1030, 212);
            this.rev_text.Multiline = true;
            this.rev_text.Name = "rev_text";
            this.rev_text.Size = new System.Drawing.Size(379, 575);
            this.rev_text.TabIndex = 25;
            this.rev_text.TextChanged += new System.EventHandler(this.rev_text_TextChanged);
            // 
            // rest_info
            // 
            this.rest_info.AutoSize = true;
            this.rest_info.BackColor = System.Drawing.SystemColors.Window;
            this.rest_info.Location = new System.Drawing.Point(296, 111);
            this.rest_info.Name = "rest_info";
            this.rest_info.Size = new System.Drawing.Size(0, 20);
            this.rest_info.TabIndex = 26;
            // 
            // rest_cho
            // 
            this.rest_cho.FormattingEnabled = true;
            this.rest_cho.Location = new System.Drawing.Point(300, 46);
            this.rest_cho.Name = "rest_cho";
            this.rest_cho.Size = new System.Drawing.Size(574, 28);
            this.rest_cho.TabIndex = 27;
            this.rest_cho.SelectedIndexChanged += new System.EventHandler(this.rest_cho_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Restaurant name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // restid_cho
            // 
            this.restid_cho.FormattingEnabled = true;
            this.restid_cho.Items.AddRange(new object[] {
            "Bubbleology|BUB",
            "Coco di Mama Kitchens|CMK",
            "Dominos Pasta|DOM",
            "Fired Pizza|FPI",
            "Gormet burger Kit|GBK",
            "Guru Raj|GUR",
            "Hangry Burger|HAB",
            "KFT|KFT",
            "Legend Fish Bar|LFB",
            "Latte Nero|LTN",
            "Las Uglies|LUG",
            "Macsick|MAC",
            "Pasta Pies|PAP",
            "Pokie & Roll|PAR",
            "Planet Burger|PBU",
            "||y3aTa XaTa|PHA",
            "Pickled Pantry|PIP",
            "Pret NO Manger|PNM",
            "Pizza-Off-Thames|POT",
            "Pappa Jons|PPJ",
            "Starlucks|SBS",
            "Shah G Kebabs|SGK",
            "Spuds|SPU",
            "Underground|UND",
            "Wings Shout|WGS"});
            this.restid_cho.Location = new System.Drawing.Point(1030, 88);
            this.restid_cho.Name = "restid_cho";
            this.restid_cho.Size = new System.Drawing.Size(379, 28);
            this.restid_cho.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1421, 799);
            this.Controls.Add(this.restid_cho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rest_cho);
            this.Controls.Add(this.rest_info);
            this.Controls.Add(this.rev_text);
            this.Controls.Add(this.publish_button);
            this.Controls.Add(this.stars_cho);
            this.Controls.Add(this.text_rev);
            this.Controls.Add(this.date_att);
            this.Controls.Add(this.date_cho);
            this.Controls.Add(this.star_ch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.login_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label star_ch;
        private System.Windows.Forms.DateTimePicker date_cho;
        private System.Windows.Forms.Label date_att;
        private System.Windows.Forms.Label text_rev;
        private System.Windows.Forms.ComboBox stars_cho;
        private System.Windows.Forms.Button publish_button;
        private System.Windows.Forms.TextBox rev_text;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label rest_info;
        private System.Windows.Forms.ComboBox rest_cho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox restid_cho;
    }
}

