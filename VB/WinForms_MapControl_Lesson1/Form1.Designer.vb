Namespace WinForms_MapControl_Lesson1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageTilesLayer()
            Dim bingMapDataProvider1 As New DevExpress.XtraMap.BingMapDataProvider()
            Dim miniMap1 As New DevExpress.XtraMap.MiniMap()
            Dim fixedMiniMapBehavior1 As New DevExpress.XtraMap.FixedMiniMapBehavior()
            Dim miniMapImageTilesLayer1 As New DevExpress.XtraMap.MiniMapImageTilesLayer()
            Dim bingMapDataProvider2 As New DevExpress.XtraMap.BingMapDataProvider()
            Dim miniMapVectorItemsLayer1 As New DevExpress.XtraMap.MiniMapVectorItemsLayer()
            Dim mapItemStorage1 As New DevExpress.XtraMap.MapItemStorage()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(45R, 18R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            bingMapDataProvider1.BingKey = "YOUR_BING_MAPS_KEY"
            imageTilesLayer1.DataProvider = bingMapDataProvider1
            Me.mapControl1.Layers.Add(imageTilesLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.BottomRight
            fixedMiniMapBehavior1.CenterPoint = New DevExpress.XtraMap.GeoPoint(45R, 18R)
            miniMap1.Behavior = fixedMiniMapBehavior1
            bingMapDataProvider2.BingKey = "YOUR BING MAPS KEY"
            miniMapImageTilesLayer1.DataProvider = bingMapDataProvider2
            miniMapVectorItemsLayer1.Data = mapItemStorage1
            miniMap1.Layers.Add(miniMapImageTilesLayer1)
            miniMap1.Layers.Add(miniMapVectorItemsLayer1)
            Me.mapControl1.MiniMap = miniMap1
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(645, 406)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 4R
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(645, 406)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
    End Class
End Namespace

