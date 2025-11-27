namespace WinForms
{
    partial class ReporteDatosVista
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
            reporteDataGriedView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)reporteDataGriedView).BeginInit();
            SuspendLayout();
            // 
            // reporteDataGriedView
            // 
            reporteDataGriedView.ColumnHeadersHeight = 29;
            reporteDataGriedView.Location = new Point(50, 34);
            reporteDataGriedView.Name = "reporteDataGriedView";
            reporteDataGriedView.RowHeadersWidth = 51;
            reporteDataGriedView.Size = new Size(705, 341);
            reporteDataGriedView.TabIndex = 0;
            // 
            // ReporteDatosVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reporteDataGriedView);
            Name = "ReporteDatosVista";
            Text = "AAReporteDatosVista";
            Load += ReporteVista_Load;
            ((System.ComponentModel.ISupportInitialize)reporteDataGriedView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView reporteDataGriedView;
    }
}