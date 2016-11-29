namespace Census_Project
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personAddressViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTownDBDataSet = new Census_Project.MyTownDBDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.homelessPersonViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vacantAddressViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.vacantAddressViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Census_Project.MyTownDBDataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personAddressViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTownDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessPersonViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantAddressViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantAddressViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Address";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // personAddressViewBindingSource
            // 
            this.personAddressViewBindingSource.DataMember = "PersonAddressView";
            this.personAddressViewBindingSource.DataSource = this.myTownDBDataSet;
            // 
            // myTownDBDataSet
            // 
            this.myTownDBDataSet.DataSetName = "MyTownDBDataSet";
            this.myTownDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Homeless Person";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // homelessPersonViewBindingSource
            // 
            this.homelessPersonViewBindingSource.DataMember = "HomelessPersonView";
            this.homelessPersonViewBindingSource.DataSource = this.myTownDBDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(651, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vacant Address";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // vacantAddressViewBindingSource
            // 
            this.vacantAddressViewBindingSource.DataSource = this.myTownDBDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(651, 309);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Person";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(651, 309);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Add Address";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // vacantAddressViewBindingSource1
            // 
            this.vacantAddressViewBindingSource1.DataMember = "VacantAddressView";
            this.vacantAddressViewBindingSource1.DataSource = this.myTownDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Census_Project.MyTownDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 335);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personAddressViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTownDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessPersonViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantAddressViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantAddressViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MyTownDBDataSet myTownDBDataSet;
        private System.Windows.Forms.BindingSource personAddressViewBindingSource;
        private MyTownDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource homelessPersonViewBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource vacantAddressViewBindingSource;
        private System.Windows.Forms.BindingSource vacantAddressViewBindingSource1;
    }
}

