﻿namespace GrapeCity.ActiveReports.Samples.Layers
{
	partial class LayersForm
	{
		/// <summary>
		/// Necessary designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean resource.
		/// </summary>
		/// <param name="disposing">True if the resource is cleaned, false is not cleaned.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code generated by Windows Form Designer

		/// <summary>
		/// Initalize necessary components.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayersForm));
			this.topPanel = new System.Windows.Forms.Panel();
			this.checkBoxPDF = new System.Windows.Forms.CheckBox();
			this.checkBoxPaper = new System.Windows.Forms.CheckBox();
			this.checkBoxScreen = new System.Windows.Forms.CheckBox();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.panelButtonContainer = new System.Windows.Forms.Panel();
			this.btnPdfExport = new System.Windows.Forms.Button();
			this.btnPreview = new System.Windows.Forms.Button();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.reportViewer = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.topPanel.SuspendLayout();
			this.panelButtonContainer.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.checkBoxPDF);
			this.topPanel.Controls.Add(this.checkBoxPaper);
			this.topPanel.Controls.Add(this.checkBoxScreen);
			this.topPanel.Controls.Add(this.rtbDescription);
			this.topPanel.Controls.Add(this.panelButtonContainer);
			resources.ApplyResources(this.topPanel, "topPanel");
			this.topPanel.Name = "topPanel";
			// 
			// checkBoxPDF
			// 
			resources.ApplyResources(this.checkBoxPDF, "checkBoxPDF");
			this.checkBoxPDF.Checked = true;
			this.checkBoxPDF.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxPDF.Name = "checkBoxPDF";
			this.checkBoxPDF.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxPaper
			// 
			resources.ApplyResources(this.checkBoxPaper, "checkBoxPaper");
			this.checkBoxPaper.Checked = true;
			this.checkBoxPaper.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxPaper.Name = "checkBoxPaper";
			this.checkBoxPaper.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxScreen
			// 
			resources.ApplyResources(this.checkBoxScreen, "checkBoxScreen");
			this.checkBoxScreen.Checked = true;
			this.checkBoxScreen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxScreen.Name = "checkBoxScreen";
			this.checkBoxScreen.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// rtbDescription
			// 
			this.rtbDescription.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.rtbDescription, "rtbDescription");
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.ReadOnly = true;
			// 
			// panelButtonContainer
			// 
			this.panelButtonContainer.Controls.Add(this.btnPdfExport);
			this.panelButtonContainer.Controls.Add(this.btnPreview);
			resources.ApplyResources(this.panelButtonContainer, "panelButtonContainer");
			this.panelButtonContainer.Name = "panelButtonContainer";
			// 
			// btnPdfExport
			// 
			resources.ApplyResources(this.btnPdfExport, "btnPdfExport");
			this.btnPdfExport.Name = "btnPdfExport";
			this.btnPdfExport.Click += new System.EventHandler(this.btnPdfExport_Click);
			// 
			// btnPreview
			// 
			resources.ApplyResources(this.btnPreview, "btnPreview");
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.reportViewer);
			resources.ApplyResources(this.bottomPanel, "bottomPanel");
			this.bottomPanel.Name = "bottomPanel";
			// 
			// reportViewer
			// 
			this.reportViewer.CurrentPage = 0;
			resources.ApplyResources(this.reportViewer, "reportViewer");
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.PreviewPages = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.reportViewer.Sidebar.ParametersPanel.ContextMenu = null;
			this.reportViewer.Sidebar.ParametersPanel.Width = 200;
			// 
			// 
			// 
			this.reportViewer.Sidebar.SearchPanel.ContextMenu = null;
			this.reportViewer.Sidebar.SearchPanel.Width = 200;
			// 
			// 
			// 
			this.reportViewer.Sidebar.ThumbnailsPanel.ContextMenu = null;
			this.reportViewer.Sidebar.ThumbnailsPanel.Width = 200;
			this.reportViewer.Sidebar.ThumbnailsPanel.Zoom = 0.1D;
			// 
			// 
			// 
			this.reportViewer.Sidebar.TocPanel.ContextMenu = null;
			this.reportViewer.Sidebar.TocPanel.Expanded = true;
			this.reportViewer.Sidebar.TocPanel.Width = 200;
			this.reportViewer.Sidebar.Width = 200;
			// 
			// LayersForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "LayersForm";
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			this.panelButtonContainer.ResumeLayout(false);
			this.bottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Panel bottomPanel;
		private GrapeCity.ActiveReports.Viewer.Win.Viewer reportViewer;
		private System.Windows.Forms.Panel panelButtonContainer;
		private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.Button btnPdfExport;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.CheckBox checkBoxScreen;
		private System.Windows.Forms.CheckBox checkBoxPaper;
		private System.Windows.Forms.CheckBox checkBoxPDF;
	}
}
