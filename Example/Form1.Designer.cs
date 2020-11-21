namespace Example
{
    partial class GeneralWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCreateTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCreate = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lineForEnterTask = new System.Windows.Forms.TextBox();
            this.listTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.deleteTask = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberTask,
            this.aimTask,
            this.timeTask,
            this.dataCreateTask});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numberTask
            // 
            this.numberTask.HeaderText = "№";
            this.numberTask.Name = "numberTask";
            // 
            // aimTask
            // 
            this.aimTask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aimTask.HeaderText = "Задание";
            this.aimTask.Name = "aimTask";
            // 
            // timeTask
            // 
            this.timeTask.HeaderText = "Время";
            this.timeTask.Name = "timeTask";
            // 
            // dataCreateTask
            // 
            this.dataCreateTask.HeaderText = "Дата создания";
            this.dataCreateTask.Name = "dataCreateTask";
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreate.Location = new System.Drawing.Point(12, 25);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(90, 30);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Location = new System.Drawing.Point(682, 25);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(90, 30);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lineForEnterTask
            // 
            this.lineForEnterTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineForEnterTask.Location = new System.Drawing.Point(211, 25);
            this.lineForEnterTask.Multiline = true;
            this.lineForEnterTask.Name = "lineForEnterTask";
            this.lineForEnterTask.Size = new System.Drawing.Size(465, 47);
            this.lineForEnterTask.TabIndex = 4;
            // 
            // listTime
            // 
            this.listTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTime.Location = new System.Drawing.Point(473, 78);
            this.listTime.Multiline = true;
            this.listTime.Name = "listTime";
            this.listTime.Size = new System.Drawing.Size(100, 20);
            this.listTime.TabIndex = 5;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(362, 81);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(105, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Время выполнения";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(105, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(132, 13);
            this.labelTask.TabIndex = 7;
            this.labelTask.Text = "Поле для ввода задания\r\n";
            // 
            // deleteTask
            // 
            this.deleteTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTask.Location = new System.Drawing.Point(108, 25);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(90, 30);
            this.deleteTask.TabIndex = 8;
            this.deleteTask.Text = "Delete";
            this.deleteTask.UseVisualStyleBackColor = false;
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Example.Properties.Resources.kisspng_emoji_bookmark_text_messaging_mastodon_sms_document_5acd080ca09930_5027111615233863806578;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.deleteTask);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.listTime);
            this.Controls.Add(this.lineForEnterTask);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "GeneralWindow";
            this.Text = "Notebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox lineForEnterTask;
        private System.Windows.Forms.TextBox listTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCreateTask;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

