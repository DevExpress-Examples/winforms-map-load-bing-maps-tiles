namespace WinForms_MapControl_Lesson1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.FixedMiniMapBehavior fixedMiniMapBehavior1 = new DevExpress.XtraMap.FixedMiniMapBehavior();
            DevExpress.XtraMap.MiniMapImageTilesLayer miniMapImageTilesLayer1 = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider2 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            DevExpress.XtraMap.MapItemStorage mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(45D, 18D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            bingMapDataProvider1.BingKey = "YOUR_BING_MAPS_KEY";
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.BottomRight;
            fixedMiniMapBehavior1.CenterPoint = new DevExpress.XtraMap.GeoPoint(45D, 18D);
            miniMap1.Behavior = fixedMiniMapBehavior1;
            bingMapDataProvider2.BingKey = "YOUR BING MAPS KEY";
            miniMapImageTilesLayer1.DataProvider = bingMapDataProvider2;
            miniMapVectorItemsLayer1.Data = mapItemStorage1;
            miniMap1.Layers.Add(miniMapImageTilesLayer1);
            miniMap1.Layers.Add(miniMapVectorItemsLayer1);
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(645, 406);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 4D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 406);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
    }
}

