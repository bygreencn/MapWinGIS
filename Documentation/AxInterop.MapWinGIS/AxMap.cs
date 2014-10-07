﻿using System;
using MapWinGIS;

#if nsp
namespace AxMapWinGIS
{
#endif
    /// <summary>
    /// Map component for visualization of vector, raster or grid data.
    /// </summary>
    /// Here is a class diagram for the AxMap class:
    /// \dot digraph map_diagram {
    /// nodesep = 0.3;
    /// ranksep = 0.3;
    /// splines = ortho;
    /// 
    /// node [shape= "component", peripheries = 1, fontname=Helvetica, fontsize=9, color = lightsalmon, style = filled, height = 0.3, width = 1.0];
    /// map [ label="AxMap" URL="\ref AxMap"];
    /// 
    /// node [shape = "polygon", color = gray, peripheries = 3, style = filled, height = 0.2, width = 0.8]
    /// img [ label="Image" URL="\ref Image"];
    /// sf [ label="Shapefile" URL="\ref Shapefile"];
    /// 
    /// node [color = tan, peripheries = 1, height = 0.3, width = 1.0];
    /// gp [ label="GeoProjection" URL="\ref GeoProjection"];
    /// meas [ label="Measuring" URL="\ref Measuring"];
    /// tiles [ label="Tiles" URL="\ref Tiles"];
    /// fm [ label="FileManager" URL="\ref FileManager"];
    /// 
    /// edge [ dir = "none", style = solid, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060", labeldistance = 0.6 ]
    /// map -> sf [ URL="\ref AxMap.get_Shapefile()", tooltip = "AxMap.get_Shapefile()", headlabel = "   n"];
    /// map -> img [URL="\ref AxMap.get_Image()", tooltip = "AxMap.get_Image()", headlabel = "   n"]
    /// 
    /// gp -> map [ URL="\ref AxMap.GeoProjection", tooltip = "AxMap.GeoProjection", taillabel = "1"];
    /// meas -> map [URL="\ref AxMap.Measuring", tooltip = "AxMap.Measuring", headlabel = "   1"]
    /// tiles -> map [URL="\ref AxMap.Tiles", tooltip = "AxMap.Tiles", headlabel = "   1"]
    /// fm -> map [URL="\ref AxMap.FileManager", tooltip = "AxMap.FileManager", taillabel = "1"]
    /// 
    /// }
    /// \enddot
    /// <a href = "diagrams.html">Graph description</a>\n\n
    /// Here are groups of API members for AxMap class:
    /// \dotfile mapgroups.dot
    /// <a href = "diagrams.html">Graph description</a>
    public class AxMap
    {
        #region _DMap Members
        /// <summary>
        /// Gets or sets a boolean value which indicates how images with identical size and position on the map will be drawn.
        /// </summary>
        /// <remarks>When set to true such images will be merged into a single bitmap. This may improve performance 
        /// in case of low number of data pixels (those which differ from the transparent color). The default value is false.</remarks>
        /// \new48 Added in version 4.8
        public bool CanUseImageGrouping
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the object of Tiles class associated with map.
        /// </summary>
        /// \new490 Added in version 4.9.0
        public MapWinGIS.Tiles Tiles
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets FileManager object associated with map. The object is used by AxMap.AddLayerFromFilename methods.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public FileManager FileManager 
        {
            get { throw new NotImplementedException();}
        }
        
        /// <summary>
        /// Applies the coloring scheme to a layer (the layer handle is specified in the coloring scheme object).
        /// </summary>
        /// <remarks>Deprecated for shapefile layers.</remarks>
        /// <param name="Legend">The coloring scheme to apply.</param>
        /// <returns>Boolean value indicating the successful application when true, unsuccessful application when false.</returns>
        public bool ApplyLegendColors(object Legend)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the background color of the map.
        /// </summary>
        /// <remarks>When using VB.NET the color is represented as a System.Drawing.Color. 
        /// When using VB 6 the color can be an OLE_COLOR or an integer representation of an RGB value.</remarks>
        public uint BackColor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
       
        /// <summary>
        /// Clears the images from the user defined list of point symbols.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        public void ClearUDPointImageList(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets whether or not the map uses double buffering. 
        /// </summary>
        /// <remarks>Double buffering uses a little more memory, but allows the view to be smoother with less flickering.
        /// The default value is true. It's not recommended to change it.</remarks>
        public bool DoubleBuffer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Draws the content of the back buffer to specified device context.
        /// </summary>
        /// <remarks>If the size of the back buffer differ from the provided dimensions, the scaling of the buffer content will be made.</remarks>
        /// <param name="hdc">The handle of the device context.</param>
        /// <param name="ImageWidth">The width of the resulting image.</param>
        /// <param name="ImageHeight">The height of the resulting image.</param>
        public void DrawBackBuffer(IntPtr hdc, int ImageWidth, int ImageHeight)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or set the point which is used as a center of the map rotation/
        /// </summary>
        /// <param name="rotX">The x coordinate of the rotation point in map units.</param>
        /// <param name="rotY">The y coordinate of the rotation point in map units.</param>
        /// <returns>The base point for rotation.</returns>
        /// \new48 Added in version 4.8
        public MapWinGIS.Point GetBaseProjectionPoint(double rotX, double rotY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a color scheme for the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the coloring scheme is required</param>
        /// <returns>The color scheme for the specified layer</returns>
        public object GetColorScheme(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the bounding box which holds the extents of the map when rotation is applied.
        /// </summary>
        /// <remarks>The bounding box is equal to the map extents when rotation angle is 0 and larger than 
        /// map extents if the angle differs from it.</remarks>
        /// <returns>The bounding box of the rotated extents.</returns>
        /// \new48 Added in version 4.8
        public MapWinGIS.Extents GetRotatedExtent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The global callback is the interface used by MapWinGIS to pass progress and error events to interested applications. 
        /// </summary>
        /// <remarks>.NET clients passing ICallback implementation to this property must make respective 
        /// class COM visible by setting ComVisible(true) attribute. In fact ComVisible(true) is set by default 
		/// for public classes, so it's enough to make sure that it isn't explicitly set to false for the class
		/// or assembly where the class is defined. Otherwise InvalidCastException may occur at runtime.</remarks>
        public object GlobalCallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Returns the handle of the window of map control.
        /// </summary>
        /// <returns>The handle of window.</returns>
        public int HWnd()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a boolean value which indicates whether the specified file holds tiff grid.
        /// </summary>
        /// <param name="Filename">The name of the file.</param>
        /// <returns>True on success and false otherwise.</returns>
        public bool IsTIFFGrid(string Filename)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The key may be used by the programmer to store any string data associated with the object.
        /// </summary>
        public string Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Retrieves the last error generated in the object.
        /// </summary>
        public int LastErrorCode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
       
        /// <summary>
        /// Gets or sets the cursor used with the map. When using crsrUserDefined be sure to set a UDCursorHandle. 
        /// </summary>
        public MapWinGIS.tkCursor MapCursor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the value which indicates how the control adjust its content after the resizing operations.
        /// </summary>
        public MapWinGIS.tkResizeBehavior MapResizeBehavior
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the angle of map rotation in degrees.
        /// </summary>
        public double MapRotationAngle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }



        /// <summary>
        /// Redraws all layers in the map if the map is not locked. 
        /// </summary>
        /// <remarks>The same as AxMap.Redraw2(tkRedrawType.RedrawAll).</remarks>
        public void Redraw()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resizes the map to the given width and height.
        /// </summary>
        /// <param name="Width">The new width of the control.</param>
        /// <param name="Height">The new hight of the control.</param>
        public void Resize(int Width, int Height)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serial number functionality is deprecated as MapWindow is now Open Source. This property may be left unset. 
        /// </summary>
        public string SerialNumber
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets a coloring scheme to be associated with an image layer. 
        /// </summary>
        /// <remarks>The coloring scheme is for reference purposes only and has no effect the coloring or display of the image.</remarks>
        /// <param name="LayerHandle">The handle of the image layer to attach the coloring scheme to.</param>
        /// <param name="ColorScheme">The coloring scheme to attach to the specified image layer.</param>
        /// <returns>Boolean value representing success when true, failure when false.</returns>
        public bool SetImageLayerColorScheme(int LayerHandle, object ColorScheme)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the drawing method for vector layers.
        /// </summary>
        /// <remarks>The default value is vdmNewSymbology. From the version 4.8 this is the only value supported.
        /// The operability of other modes isn't guaranteed.</remarks>
        /// \new48 Added in version 4.8
        /// \deprecated v 4.8 The default value of the property must be used.
        public MapWinGIS.tkShapeDrawingMethod ShapeDrawingMethod
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value which indicates whether the time of map redraw will be displayed on the screen.
        /// </summary>
        /// <remarks>Only times of full redraws when data layers are drawn anew are displayed.</remarks>
        /// \new48 Added in version 4.8
        public bool ShowRedrawTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Shows tooltip near the mouse cursor.
        /// </summary>
        /// <param name="Text">Text of the tooltip.</param>
        /// <param name="Milliseconds">The duration of tooltip display.</param>
        public void ShowToolTip(string Text, int Milliseconds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets a boolean value which indicate whether control's version number will be displayed on the screen.
        /// </summary>
        /// \new48 Added in version 4.8
        public bool ShowVersionNumber
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Takes snap shot of the contents of the map within the bounds of the specified rectangle, returning an image of the results. 
        /// </summary>
        /// <param name="BoundBox">The bounds (rectangle) in map units to get the snapshot from.</param>
        /// <returns>An image of the contents of the map displayed inside the bounds of the specified rectangle.</returns>
        public object SnapShot(object BoundBox)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Takes snap shot of the contents of the map and returns it as an image object. 
        /// </summary>
        /// <param name="ClippingLayerNbr">The position of the layer which extents will be used for taking snapshot.</param>
        /// <param name="Zoom">The amount of zoom.</param>
        /// <param name="pWidth">The width of the resulting image.</param>
        /// <returns>An image of the contents of the map.</returns>
        public object SnapShot2(int ClippingLayerNbr, double Zoom, int pWidth)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Takes snap shot of the contents of the map in the specified bounding box and returns it as an image object. 
        /// </summary>
        /// <param name="left">The x coordinate of the lower left corner of the extents.</param>
        /// <param name="right">The x coordinate of the top right corner of the extents.</param>
        /// <param name="top">The y coordinate of the top right corner of the extents.</param>
        /// <param name="bottom">The y coordinate of the lower left corner of the extents.</param>
        /// <param name="Width">The width of the resulting image in pixels.</param>
        /// <returns>An image of the contents of the map.</returns>
        /// 
        public object SnapShot3(double left, double right, double top, double bottom, int Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs drawing of the map contents to the specified device context.
        /// </summary>
        /// <param name="hdc">The handle of the device context.</param>
        /// <param name="Extents">The map extents to be drawn.</param>
        /// <param name="Width">The width of the resulting image inShowVersionNumber pixels.</param>
        /// <returns>True on success and false otherwise.</returns>
        public bool SnapShotToDC(IntPtr hdc, MapWinGIS.Extents Extents, int Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the display of the specified image object.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        public void UpdateImage(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets version number of the control.
        /// </summary>
        /// <remarks>The set part of the property isn't supported.</remarks>
        public int VersionNumber
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Retrieves the error message associated with the specified error code.
        /// </summary>
        /// <param name="ErrorCode">The error code for which the error message is required.  </param>
        /// <returns>The error message description for the specified error code.</returns>
        public string get_ErrorMsg(int ErrorCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the filename of the Grid object associated with an Image object loaded into the map.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the grid filename is to be set.</param>
        /// <returns>The grid filename to be associated with the specified layer.</returns>
        /// \deprecated v 4.9.1 Use Image.SourceGridName instead.
        public string get_GridFileName(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the percentage of transparency of an Image layer.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the Image layer for which the transparency is to be set.</param>
        /// <returns>The percentage of transparency for the specified image layer.</returns>
        public float get_ImageLayerPercentTransparent(int LayerHandle)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets the filename of the grid associated with the specified layer.
        /// </summary>
        /// <remarks>MapWinGIS will create a bitmap representation for the grid and use instance of Image class for display.</remarks>
        /// <param name="LayerHandle">The layer handle.</param>
        /// <param name="__p2">The name of the file with grid.</param>
        /// \deprecated v 4.9.1 Use Image.SourceGridName instead.
        public void set_GridFileName(int LayerHandle, string __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the numeric value which determines the transparency of the given image layer.
        /// </summary>
        /// <remarks>It is recommended to the properties of the Image class directly.</remarks>
        /// <param name="LayerHandle">The handle of the layer with the image.</param>
        /// <param name="__p2">The value ranging from 0.0(transparent) to 1.0(opaque).</param>
        /// \see AxMap.get_Image()
        public void set_ImageLayerPercentTransparent(int LayerHandle, float __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets tile provider for the map.
        /// </summary>
        /// <remarks>This property is a shortcut for AxMap.Tiles.Provider property. 
        /// Setting it to ProviderNone will change AxMap.Tiles.Visible property to false.</remarks>
        /// \new491 Added in version 4.9.1
        public tkTileProvider TileProvider { get; set; }

        /// <summary>
        /// Returns coordinate of the shapefile point closest to specified point on screen.
        /// </summary>
        /// <param name="tolerance">Tolerance in screen pixels. If no vertex is found within the tolerance, operation fails.</param>
        /// <param name="xScreen">X coordinate on screen.</param>
        /// <param name="yScreen">Y coordinate on screen.</param>
        /// <param name="xFound">X coordinate of the vertex (map coordinates).</param>
        /// <param name="yFound">Y coordinate of the vertex (map coordinates).</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool FindSnapPoint(double tolerance, double xScreen, double yScreen, ref double xFound, ref double yFound)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads tiles for the specified map extents.
        /// </summary>
        /// <param name="extents">Extents to load tiles for (in map coordinates).</param>
        /// <param name="width">The width of the canvas on which the extents will be rendered.</param>
        /// <param name="key">Arbitrary key, to distinguish this request from others in AxMap.TilesLoaded event.</param>
        /// <param name="provider">Provider to load tiles from.</param>
        /// <remarks>If tiles aren't already loaded in cache, the operation will be performed asynchronously.
        /// Use AxMap.TilesLoaded event to be notified of it's completion. The main purpose: loading of tiles
        /// for printing.</remarks>
        /// \new491 Added in version 4.9.1
        public void LoadTilesForSnapshot(Extents extents, int width, string key, tkTileProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether tiles for specified extents and provider are already present in cache.
        /// </summary>
        /// <param name="extents">Extents to check for (map coordinates).</param>
        /// <param name="width">Width of the canvas on which the extents will be displayed.</param>
        /// <param name="provider">Provider to load tiles from.</param>
        /// <returns>1 if tiles are in cache, 0 if not, -1 if an there was an error.</returns>
        /// <remarks>The main purpose: loading of tiles for printing.</remarks>
        /// \new491 Added in version 4.9.1
        public int TilesAreInCache(Extents extents, int width, tkTileProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs specific type of map redraw. 
        /// </summary>
        /// <param name="redrawType">Type of redraw.</param>
        /// <remarks>Map.Redraw is the same as AxMap.Redraw(tkRedrawType.RedrawAll).</remarks>
        /// \new491 Added in version 4.9.1
        public void Redraw2(tkRedrawType redrawType)
        {
            throw new NotImplementedException();
        }
       
        #endregion

        /// The modules listed here are parts of the documentation of AxMap class.
        /// \dotfile mapgroups.dot
        /// <a href = "diagrams.html">Graph description</a>
        /// \addtogroup map_modules Map modules
        /// @{

        #region Labels
        /// \addtogroup map_labels Map labels
        /// Here is a list of properties and methods to add and remove labels on the map.
        /// All these method are redirected to the instances of the Labels class for particular layers.
        /// Consider referring to those instances directly to improve performance (see Shapefile.Labels and Image.Labels).
        /// This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_labels {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Map Labels" URL="\ref map_labels"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Adds a label to the map.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer where the label will be added to.</param>
        /// <param name="Text">The text to be used for the label.</param>
        /// <param name="Color">The color of the added label. This is a UInt32 representation of an RGB color.</param>
        /// <param name="x">The x coordinate in projected map units which determines where the label will be added on the map.</param>
        /// <param name="y">The y coordinate in projected map units which determines where the label will be added on the map.</param>
        /// <param name="hJustification">Specifies whether to justify the label's text right, left, or center. </param>
        public void AddLabel(int LayerHandle, string Text, uint Color, double x, double y, MapWinGIS.tkHJustification hJustification)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds an extended label to the map, allowing for rotated labels.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer where the label will be added to.</param>
        /// <param name="Text">The text to be used for the label.</param>
        /// <param name="Color">The color of the added label. This is a UInt32 representation of an RGB color.</param>
        /// <param name="x">The x coordinate in projected map units which determines where the label will be added on the map.</param>
        /// <param name="y">The y coordinate in projected map units which determines where the label will be added on the map.</param>
        /// <param name="hJustification">Specifies whether to justify the label's text right, left, or center.</param>
        /// <param name="Rotation">The number of degrees to rotate the label. Positive angles rotate the text counter-clockwise, and
        /// negative angles rotate the text clockwise</param>
        public void AddLabelEx(int LayerHandle, string Text, uint Color, double x, double y, MapWinGIS.tkHJustification hJustification, double Rotation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears all labels that have been added to the specified layer.
        /// </summary>
        /// <param name="LayerHandle"></param>
        public void ClearLabels(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the offset for the labels on the layer. 
        /// </summary>
        /// <remarks>The offset is the distance in pixels from the label point to the text.</remarks>
        /// <param name="LayerHandle">The handle of the layer for which the offset is to be set.</param>
        /// <returns>The offset for the labels on the specified layer.</returns>
        public int get_LayerLabelsOffset(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the offset for the labels on the layer. 
        /// </summary>
        /// <remarks>The offset is the distance in pixels from the label point to the text.</remarks>
        /// <param name="LayerHandle">The handle of the layer for which the offset is to be set. </param>
        /// <param name="__p2">The offset for the labels on the specified layer.</param>
        public void set_LayerLabelsOffset(int LayerHandle, int __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets whether to scale the labels on the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the scaling of labels is to be set.</param>
        /// <returns>A boolean value representing whether or not to scale the labels on the specified layer.</returns>
        public bool get_LayerLabelsScale(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets whether to scale the labels on the layer
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the scaling of labels is to be set.</param>
        /// <param name="__p2">A boolean value representing whether or not to scale the labels on the specified layer.</param>
        public void set_LayerLabelsScale(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets whether to use shadows for the labels on the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the use of label shadows is to be set.</param>
        /// <returns>A boolean value representing whether or not label shadows will be used for the specified layer. </returns>
        public bool get_LayerLabelsShadow(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets whether to use shadows for the labels on the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the use of label shadows is to be set. </param>
        /// <param name="__p2">A boolean value representing whether or not label shadows will be used for the specified layer.</param>
        public void set_LayerLabelsShadow(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the shadow color for the labels on the layer
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the shadow color is to be set.</param>
        /// <returns>The color to use the shadow color of the specified layer. 
        /// This is a System.UInt32 representation of an RGB color.</returns>
        public uint get_LayerLabelsShadowColor(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the shadow color for the labels on the layer. 
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the shadow color is to be set.</param>
        /// <param name="__p2">The color of use as the shadow color of the specified layer. 
        /// This is a System.UInt32 representation of an RGB color.</param>
        public void set_LayerLabelsShadowColor(int LayerHandle, uint __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets label visibility for the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle for the layer for which its label's visibility are to be set.</param>
        /// <returns>A boolean value which determines whether the specified layer's labels are visible or not.</returns>
        public bool get_LayerLabelsVisible(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets label visibility for the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The layer handle for the layer for which its label's visibility are to be set.</param>
        /// <param name="__p2">A boolean value which determines whether the specified layer's labels are visible or not. </param>
        public void set_LayerLabelsVisible(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the standard view width used to scale the labels on the layer
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the standard view width is required.</param>
        /// <param name="Width">Reference parameter. The standard view width for the specified layer is returned through this parameter.</param>
        public void GetLayerStandardViewWidth(int LayerHandle, ref double Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the standard view width used to scale the labels on the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the standard view width is to be set.</param>
        /// <param name="Width">The new standard view width for the specified layer.</param>
        public void SetLayerStandardViewWidth(int LayerHandle, double Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a boolean value which indicates whether overlapping labels will be allowed for the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>True in case overlapping labels will be prevented and false otherwise.</returns>
        public bool get_UseLabelCollision(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether overlapping labels will be allowed for the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">True in case overlapping labels will be forbidden and false otherwise.</param>
        public void set_UseLabelCollision(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the color of the font for labels of the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="LabelFontColor">The color of the labels font.</param>
        public void LabelColor(int LayerHandle, uint LabelFontColor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the font to use when drawing labels for a layer.
        /// </summary>
        /// <param name="LayerHandle">Layer handle of the layer for which the label fonts are to be set.</param>
        /// <param name="FontName">Name of the font to use for the labels. (Ex: "Arial") </param>
        /// <param name="FontSize">Size of the font to use for the labels.</param>
        public void LayerFont(int LayerHandle, string FontName, int FontSize)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the font for labels of the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="FontName">The name of the font.</param>
        /// <param name="FontSize">The size of the font.</param>
        /// <param name="isBold">A boolean value which indicates whether the font is bold.</param>
        /// <param name="isItalic">A boolean value which indicates whether the font is italic.</param>
        /// <param name="isUnderline">A boolean value which indicates whether the font is underlined.</param>
        public void LayerFontEx(int LayerHandle, string FontName, int FontSize, bool isBold, bool isItalic, bool isUnderline)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets a boolean value which indicates whether multiline labels will be drawn correctly on the map.
        /// </summary>
        /// \deprecated v 4.8. Multiline labels will be drawn after specification of appropriate label expression. 
        /// \see Labels.Expression.
        public bool MultilineLabels
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        
        /// @}
        #endregion

        #region Drawing labels
        /// \addtogroup map_drawing_labels Drawing labels
        /// Here is a list of properties and methods to add and remove labels on drawing layer of the map. It's possible to change even more
        ///  properties using instance of Labels class obtained by AxMap.get_DrawingLabels() property. 
        ///  This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_drawing_labels {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Drawing Labels" URL="\ref map_drawing_labels"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Adds label to the specified drawing layer.
        /// </summary>
        /// <remarks>This method corresponds to the Labels.AddLabel method.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="Text">The text of the label.</param>
        /// <param name="Color">The color of the label.</param>
        /// <param name="x">The x coordinate of the label.</param>
        /// <param name="y">The y coordinate of the label.</param>
        /// <param name="hJustification">The justification of the label.</param>
        public void AddDrawingLabel(int DrawHandle, string Text, uint Color, double x, double y, tkHJustification hJustification)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds label to the specified drawing layer. Angle of rotation is accepted.
        /// </summary>
        /// <remarks>This method corresponds to the Labels.AddLabel method.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="Text">The text of the label.</param>
        /// <param name="Color">The color of the label.</param>
        /// <param name="x">The x coordinate of the label.</param>
        /// <param name="y">The y coordinate of the label.</param>
        /// <param name="hJustification">The justification of the label.</param>
        /// <param name="Rotation">The angle of rotation in degrees.</param>
        public void AddDrawingLabelEx(int DrawHandle, string Text, uint Color, double x, double y, tkHJustification hJustification, double Rotation)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Clears labels on the specified drawing layer.
        /// </summary>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        public void ClearDrawingLabels(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value which affects the scaling of labels.
        /// </summary>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="Width">The standard width of the view in pixels to use normal size of labels.</param>
        /// \deprecated v 4.8. Use Labels.ScaleLabels, Labels.BaseScale instead.
        public void GetDrawingStandardViewWidth(int DrawHandle, ref double Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets labels associated with the drawing layer.
        /// </summary>
        /// <param name="DrawingLayerIndex">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>The reference to the Labels class or NULL reference on the invalid handle.</returns>
        public Labels get_DrawingLabels(int DrawingLayerIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replaces the labels associated with the drawing layer.
        /// </summary>
        /// <param name="DrawingLayerIndex">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">The new instance of the Labels class to associate with the layer.</param>
        public void set_DrawingLabels(int DrawingLayerIndex, Labels __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the vertical offset of the labels for the specified drawing layer in pixels.
        /// </summary>
        /// <param name="DrawHandle">The index of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>The offset in pixels.</returns>
        /// \deprecated v. 4.8. Use AxMap.get_DrawingLabels and Labels.OffsetX, Labels.OffsetY instead.
        public int get_DrawingLabelsOffset(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the vertical offset of the labels for the specified drawing layer in pixels.
        /// </summary>
        /// <param name="DrawHandle">The index of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">The offset in pixels.</param>
        /// \deprecated v. 4.8. Use AxMap.get_DrawingLabels and Labels.OffsetX, Labels.OffsetY instead.
        public void set_DrawingLabelsOffset(int DrawHandle, int __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a boolean value which indicates whether the labels of the drawing layer will be scaled.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.ScaleLabels property.</remarks>
        /// <param name="DrawHandle">he index of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>True if the labels are scaled and false otherwise.</returns>
        public bool get_DrawingLabelsScale(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether the labels of the drawing layer will be scaled.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.ScaleLabels property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">True if the labels are scaled and false otherwise.</param>
        public void set_DrawingLabelsScale(int DrawHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a boolean value which indicates whether a shadow will be displayed for the labels of the drawing layer.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.HaloVisible property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>True if the shadow is displayed and false otherwise.</returns>
        public bool get_DrawingLabelsShadow(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether a shadow will be displayed for the labels of the drawing layer.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.HaloVisible property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">True if the shadow is displayed and false otherwise.</param>
        public void set_DrawingLabelsShadow(int DrawHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the color of the shadow for the labels of the specified drawing layer.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.HaloColor property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>The color of shadow.</returns>
        public uint get_DrawingLabelsShadowColor(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the color of the shadow for the labels of the specified drawing layer.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.HaloColor property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">The color of shadow.</param>
        public void set_DrawingLabelsShadowColor(int DrawHandle, uint __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a boolean value which indicates whether labels of the drawing layer are visible.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.Visible property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>True in case labels are visible and false otherwise.</returns>
        public bool get_DrawingLabelsVisible(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether labels of the drawing layer are visible.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.Visible property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">True in case labels are visible and false otherwise.</param>
        public void set_DrawingLabelsVisible(int DrawHandle, bool __p2)
        {
            throw new NotImplementedException();
        }
              
        /// <summary>
        /// Gets a boolean value which indicates whether overlapping labels will be allowed for drawing layer.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.AvoidCollisions property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <returns>True in case overlapping labels are removed and false otherwise.</returns>
        public bool get_UseDrawingLabelCollision(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether overlapping labels will be allowed for drawing layer.
        /// </summary>
        /// <remarks>This property corresponds to the Labels.AllowCollisions property.</remarks>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="__p2">True in case overlapping labels are removed and false otherwise.</param>
        public void set_UseDrawingLabelCollision(int DrawHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the font for the labels of the drawing layer.
        /// </summary>
        /// <param name="DrawHandle">The handle of the drawing layer returned by AxMap.NewDrawing method.</param>
        /// <param name="FontName">The name of the font.</param>
        /// <param name="FontSize">The size of the font.</param>
        public void DrawingFont(int DrawHandle, string FontName, int FontSize)
        {
            throw new NotImplementedException();
        }

        /// @}
        #endregion

        #region User-defined symbology
        /// \addtogroup map_user_defined User-defined symbology
        /// Here is a list of properties and methods to create a custom symbology for shapefile layers. 
        /// This module is a part of the documentation of AxMap class.\n\n
        /// Most of the properties listed here are deprecated. Consider using ShapeDrawingOptions class instead.
        /// \dot
        /// digraph map_user_defined {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = gray, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="User-Defined Symbology" URL="\ref map_user_defined"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Gets or sets the user defined cursor handle. The handle is a windows cursor handle. 
        /// </summary>
        public int UDCursorHandle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets line separation factor.
        /// </summary>
        /// \deprecated v4.8. Use LinePattern class, and ShapeDrawingOptions.LinePattern property instead.
        public int LineSeparationFactor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets one user defined stipple row.
        /// </summary> 
        /// <remarks>The user defined fill stipple contains 32 rows of 32 bits. The stipple is created by
        /// setting patterns in the bits contained in each row.</remarks>
        /// <param name="LayerHandle">The handle of the layer for which the fill stipple is to be set. </param>
        /// <param name="StippleRow">The row in the custom stipple for which the pattern is to be set. </param>
        /// <returns>The custom fill stipple as an integer value where the stipple is defined 
        /// by arranging the 32 bits in desired pattern.</returns>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.FillHatchStyle instead.
        public int get_UDFillStipple(int LayerHandle, int StippleRow)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets one user defined stipple row. 
        /// </summary>
        /// <remarks>The user defined fill stipple contains 32 rows of 32 bits. 
        /// The stipple is created by setting patterns in the bits contained in each row.</remarks>
        /// <param name="LayerHandle">The handle of the layer for which the fill stipple is to be set. </param>
        /// <param name="StippleRow">The row in the custom stipple for which the pattern is to be set. </param>
        /// <param name="__p3">The custom fill stipple as an integer value where the stipple is defined 
        /// by arranging the 32 bits in desired pattern</param>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.FillHatchStyle instead.
        public void set_UDFillStipple(int LayerHandle, int StippleRow, int __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the user defined line stipple for the specified layer.
        /// </summary>
        /// <remarks>The user defined line stipple is represented by an Integer (VB.NET) or a Long (VB 6). The first digit represents the stipple 
        /// multiplier. Each of the following digits alternate between representing pixels drawn and pixels skipped in the pattern. The 
        /// number of pixels to be drawn or skipped are determined by multiplying the digit representing that segment of the stipple by 
        /// the stipple multiplier.\n
        /// This custom line stipple would draw six pixels(2*3), skip eight pixels(2*4), draw ten pixels(2*5), skip twelve pixels(2*6), with 
        /// the pattern repeating from the beginning after that. The largest valid line stipple is 2147483647. Any value greater than this 
        /// will result in overflow. A line stipple value less than 111 will result in a solid line.</remarks>
        /// <param name="LayerHandle">The handle of the layer for which the user defined shape line stipple is to be set.</param>
        /// <returns>The user defined line stipple.</returns>
        /// \deprecated v.4.8. Use LinePattern class instead.
        public int get_UDLineStipple(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the user defined line stipple for the specified layer.
        /// </summary>
        /// <remarks>The user defined line stipple is represented by an Integer (VB.NET) or a Long (VB 6). The first digit represents the stipple 
        /// multiplier. Each of the following digits alternate between representing pixels drawn and pixels skipped in the pattern. The 
        /// number of pixels to be drawn or skipped are determined by multiplying the digit representing that segment of the stipple by 
        /// the stipple multiplier.\n
        /// This custom line stipple would draw six pixels(2*3), skip eight pixels(2*4), draw ten pixels(2*5), skip twelve pixels(2*6), with 
        /// the pattern repeating from the beginning after that. The largest valid line stipple is 2147483647. Any value greater than this 
        /// will result in overflow. A line stipple value less than 111 will result in a solid line. 
        /// </remarks>
        /// <param name="LayerHandle">The handle of the layer for which the user defined shape line stipple is to be set.</param>
        /// <param name="__p2">The user defined line stipple.</param>
        /// \deprecated v.4.8. Use LinePattern class instead.
        public void set_UDLineStipple(int LayerHandle, int __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the font for point markers defined by font characters. 
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="FontName">The name of the font.</param>
        /// <param name="FontSize">The size of the font.</param>
        /// <param name="isBold">A boolean value which indicates whether the font is bold.</param>
        /// <param name="isItalic">A boolean value which indicates whether the font is italic.</param>
        /// <param name="isUnderline">A boolean value which indicates whether the font is underlined.</param>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.PointCharacter and ShapefileCategories instead.
        public void set_UDPointFontCharFont(int LayerHandle, string FontName, float FontSize, bool isBold, bool isItalic, bool isUnderline)
        {
            throw new NotImplementedException();
        }

       /// <summary>
        /// Sets the font size for point markers defined by font characters. 
       /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="FontSize">The size of the font.</param>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.PointCharacter and ShapefileCategories instead.
        public void set_UDPointFontCharFontSize(int LayerHandle, float FontSize)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new item in the list of point markers defined by font characters
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="newValue">The ANSI code of the new character.</param>
        /// <param name="Color">The color of the marker.</param>
        /// <returns>The index of the new font character in the list of markers.</returns>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.PointCharacter and ShapefileCategories instead.
        public int set_UDPointFontCharListAdd(int LayerHandle, int newValue, uint Color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows you to build an image list so that one point shapefile can have multiple icons. 
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the image list is defined.</param>
        /// <param name="newValue">The Integer index for the image to retrieve </param>
        /// <returns>The image object which is used as the point image for the specified layer.</returns>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.Picture and ShapefileCategories instead.
        public int set_UDPointImageListAdd(int LayerHandle, object newValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of images currently stored in the image list for custom points images. 
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the image list is defined. </param>
        /// <returns>The Count of images currently stored in the image index of custom point types for that layer. 
        /// Remember to subtract 1 from this count when indexing the 0 based image list. 
        /// </returns>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.Picture and ShapefileCategories instead.
        public int get_UDPointImageListCount(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows you to build an image list so that one point shapefile can have multiple icons.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the image list is defined.</param>
        /// <param name="ImageIndex">The Integer index for the image to retrieve</param>
        /// <returns>The image object which is used as the point image for the specified layer.</returns>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.Picture and ShapefileCategories instead.
        public object get_UDPointImageListItem(int LayerHandle, int ImageIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the image used when drawing points on the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the point type is required.</param>
        /// <returns>The image object which is used as the point image for the specified layer.</returns>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.PointType instead.
        public object get_UDPointType(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the image used when drawing points on the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the point type is required.</param>
        /// <param name="__p2">The image object which is used as the point image for the specified layer.</param>
        /// \deprecated v.4.8. Use ShapeDrawingOptions.PointType instead.
        public void set_UDPointType(int LayerHandle, object __p2)
        {
            throw new NotImplementedException();
        }

        /// @}
        #endregion

        #region Map interaction
        /// \addtogroup map_interaction Map interaction
        /// Here is a list of properties and methods which affect the way a user interacts with the map. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_interaction {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Map Interaction" URL="\ref map_interaction"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Gets or sets a boolean value which indicate whether map will be redrawn in the course of panning operation.
        /// </summary>
        /// <remarks>The default value is false. Setting this value to true can improve the user experience but 
        /// decrease the performance in case large layers are displayed.</remarks>
        /// \new48 Added in version 4.8
        public bool UseSeamlessPan
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the cursor mode for the map. 
        /// </summary>
        /// <remarks>The cursor mode determines how the map handles mouse click events on the map. The only mode not handled by the map is cmNone.</remarks>
        public MapWinGIS.tkCursorMode CursorMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets zoom behaviour for the map control.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public tkZoomBehavior ZoomBehavior { get; set; }

        /// <summary>
        /// Zoomes map to display selected shapes of the specified shapefile.
        /// </summary>
        /// <param name="layerHandle">Layer handle of shapefile layer with selected shapes.</param>
        /// <returns>True on success.</returns>
        /// <remarks>If the layer isn't shapefile or there is no selected shapes in it, nothing will happen.</remarks>
        /// \new490 Added in version 4.9.0
        public bool ZoomToSelected(int layerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms map to specified zoom level of the active tile provider (Map.Tiles.Provider).
        /// </summary>
        /// <param name="zoom">Zoom</param>
        /// <returns>True if the zooming took place.</returns>
        /// \new491 Added in version 4.9.1
        public bool ZoomToTileLevel(int zoom)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms to World extents (-180.0; 180.0; -90.0; 90.0) 
        /// </summary>
        /// <remarks>Projection should be specified for map in order for this methods to work.</remarks>
        /// <returns>True on success.</returns>
        /// \new490 Added in version 4.9.0
        public bool ZoomToWorld()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks to see if the map is currently locked or not.
        /// </summary>
        public MapWinGIS.tkLockMode IsLocked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Locks the window so that any changes will not be displayed until it is unlocked. 
        /// </summary>
        /// <remarks>This is very useful if you are making a large number of changes at once and don't want the map to be redrawn between each change.
        /// The changes of drawing options in the related classes (Shapefile, Labels, etc.) won't cause the redraw of the map even if it's not locked.</remarks>
        /// <param name="LockMode">The state of the lock mode.</param>
        public void LockWindow(MapWinGIS.tkLockMode LockMode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets a boolean value which indicates whether a wait cursor will be displayed on map redraw.
        /// </summary>
        public bool DisableWaitCursor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the speed of zooming with mouse wheel.
        /// </summary>
        /// <remarks>The default values is 0.5. The values in 0.1 - 10.0 range are accepted. The value 1.0 will turn off
        /// the zooming by mouse wheel.</remarks>
        public double MouseWheelSpeed
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets whether the map sends mouse down events. 
        /// </summary>
        public bool SendMouseDown
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets whether the map sends mouse move events. 
        /// </summary>
        public bool SendMouseMove
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets whether the map sends mouse up events.
        /// </summary>
        public bool SendMouseUp
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a boolean value which indicates whether the map sends on draw back buffer events.
        /// </summary>
        public bool SendOnDrawBackBuffer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets whether the map sends the SelectBoxDrag event.
        /// </summary>
        public bool SendSelectBoxDrag
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets whether the map sends the SelectBoxFinal event. 
        /// </summary>
        public bool SendSelectBoxFinal
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a boolean value which can affect the displaying of the context menus in client code by the right click.
        /// </summary>
        public bool TrapRMouseDown
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Zooms the display in by the given factor.
        /// </summary>
        /// <param name="Percent">The factor to zoom in by.</param>
        public void ZoomIn(double Percent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms the display out by the specified factor.
        /// </summary>
        /// <param name="Percent">The factor to zoom out by.</param>
        public void ZoomOut(double Percent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the factor by which to zoom the view of the map in or out.
        /// </summary>
        public double ZoomPercent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Zooms the map display to the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer to zoom to.</param>
        public void ZoomToLayer(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms the map to the maximum extents of all loaded layers.  
        /// </summary>
        /// <remarks>Layers which are not visible are still used to compute maximum extents.</remarks>
        public void ZoomToMaxExtents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms the map to the maximum extents of all loaded visible layers.
        /// </summary>
        /// <remarks> Layers which are not visible are not used to compute maximum extents.</remarks>
        public void ZoomToMaxVisibleExtents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms the map view to the previous extents if there are previous extents in the extents history.
        /// </summary>
        /// <returns>Returns the number of extents left in the extents history after zooming to previous extents.</returns>
        public int ZoomToPrev()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zooms the map display to the specified shape in the shapefile contained by the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer containing the shape to zoom to.</param>
        /// <param name="Shape">The index of the shape to zoom to.</param>
        public void ZoomToShape(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets a value indicating whether zoom bar will be displayed on the map.
        /// </summary>
        /// <remarks>Zoom bar can be displayed only if projection of the map is set. Zoom levels
        /// depend upon tile of the current tile provider.</remarks>
        /// /see AxMap.TileProvider, AxMap.Projection
        /// \new492 Added in version 4.9.2
        public bool ShowZoomBar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether animation will be displayed zooming map in or out.
        /// </summary>
        /// <remarks>Default csAuto value will display animation only if there are no data layers
        /// within visisble extents. Animation also won't be displayed if there are more than 4
        /// zoom levels between current and target level.</remarks>
        /// \new492 Added in version 4.9.2
        public tkCustomState AnimationOnZooming { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether animation will be displayed to simulate 
        /// inertia after panning operation.
        /// </summary>
        /// <remarks>Default csAuto value will display animation only if there are no data layers
        /// within visisble extents.
        /// \note Mouse panning is somewhat more tricky than the one with smartphone's touch screen,
        /// so some practice may be needed to learn not to stop mouse motion before releasing the button )))
        /// </remarks>
        /// \new492 Added in version 4.9.2
        public tkCustomState InertiaOnPanning { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether currently rendered tile buffer should be scaled 
        /// and reused during the next redraw.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public bool ReuseTileBuffer { get; set; }

        /// <summary>
        /// Gets or sets the amount of information to be displayed in zoom bar tool tip.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public tkZoomBarVerbosity ZoomBarVerbosity { get; set; }

        /// <summary>
        /// Gets or sets a style of zoom box, which is used to select a region with Zoom In tool.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public tkZoomBoxStyle ZoomBoxStyle { get; set; }

        /// <summary>
        /// Gets or sets minimum zoom level to be used by zoom bar.
        /// </summary>
        /// <remarks>This property won't increase the number of avaialbe levels, 
        /// if certain levels aren't supported by the provider they still won't be displayed.</remarks>
        /// \new492 Added in version 4.9.2
        public int ZoomBarMinZoom { get; set; }

        /// <summary>
        /// Gets or sets maximum zoom level to be used by zoom bar.
        /// </summary>
        /// <remarks>This property won't increase the number of avaialbe levels, 
        /// if certain levels aren't supported by the provider they still won't be displayed.</remarks>
        /// \new492 Added in version 4.9.2
        public int ZoomBarMaxZoom { get; set; }

        /// @}
        #endregion

        #region Map serialization
        /// \addtogroup map_serialization Map serialization
        /// Here is a list of properties and methods to preserve the state of the map and particular layers. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_serialization {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Map Serialization" URL="\ref map_serialization"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Serializes the layer settings to the string.
        /// </summary>
        /// <remarks>The serialized string will not include information about the data source. Therefore
        /// the same options can later be applied to any data layer of the same type (either shapefile or image).</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The string with serialized layer settings.</returns>
        /// \new48 Added in version 4.8
        public string SerializeLayer(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Restores the state of the layer from the string generated by AxMap.SerializeLayer().
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="newVal">The string to restore values from.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool DeserializeLayer(int LayerHandle, string newVal)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serializes map state to the string.
        /// </summary>
        /// <param name="RelativePaths">A value which indicates whether relative or absolute paths to data sources will be used.</param>
        /// <param name="BasePath">The path to the base folder starting from which relative paths will be calculated.</param>
        /// <returns>The string with the serialized map state.</returns>
        /// \new48 Added in version 4.8
        public string SerializeMapState(bool RelativePaths, string BasePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Restores map state from the string generated by AxMap.SerializeMapState.
        /// </summary>
        /// <remarks>This method will remove all the existing layers and load the layers specified in the string.</remarks>
        /// <param name="State">The string with serialized state.</param>
        /// <param name="LoadLayers">A boolean value which indicates whether layers or only options of the map control will restored.</param>
        /// <param name="BasePath">The path to the base folder starting from which relative paths were calculated.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool DeserializeMapState(string State, bool LoadLayers, string BasePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Applies to the layer a set of settings from file with the specified name.
        /// </summary>
        /// <remarks>The options will be loaded from the file with the name [LayerName].[OptionsName].mwsymb</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="OptionsName">The name of the set of options.</param>
        /// <param name="Description">The output string which will hold the description of the options stored in file.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool LoadLayerOptions(int LayerHandle, string OptionsName, ref string Description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes set of options for the layer with the specified name.
        /// </summary>
        /// <remarks>The options are stored in files with the name [LayerName].[OptionsName].mwsymb</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="OptionsName">The name of the set of options.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool RemoveLayerOptions(int LayerHandle, string OptionsName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves settings of the layer to the file.
        /// </summary>
        /// <remarks>The options are saved to the file with name [LayerName].[OptionsName].mwsymb</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="OptionsName">The name which will be attached to the set of options.</param>
        /// <param name="Overwrite">A value which indicates whether the existing file will be overwritten.</param>
        /// <param name="Description">The description associated with the set of options.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool SaveLayerOptions(int LayerHandle, string OptionsName, bool Overwrite, string Description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the state of the map from the file created by AxMap.SaveMapState method.
        /// </summary>
        /// <param name="Filename">The name of the file.</param>
        /// <param name="Callback">A callback object to return information about progress and errors.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool LoadMapState(string Filename, object Callback)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the MapState string which stores all information needed to restore a view. 
        /// </summary>
        /// <remarks>This includes layer information and coloring schemes.</remarks>
        /// \deprecated v.4.8 Use AxMap.SerializeMapState instead.
        public string MapState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Saves the state of the map to the specified file.
        /// </summary>
        /// <remarks>Use AxMap.LoadState for reverse operation.</remarks>
        /// The serialized state include:
        /// - properties of the control;
        /// - references to the layers;
        /// - drawing options for the layers.
        /// .
        /// <param name="Filename">The name of the file.</param>
        /// <param name="RelativePaths">A value which indicates whether absolute or relative paths should be used.</param>
        /// <param name="Overwrite">A value which indicates whether the exiting file will be overwritten.</param>
        /// <returns>True on success and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool SaveMapState(string Filename, bool RelativePaths, bool Overwrite)
        {
            throw new NotImplementedException();
        }

        /// @}
        #endregion

        #region Layer properties
        /// \addtogroup map_layer_properties Layer properties
        /// Here is a list of properties common to all data layers. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_layer_properties {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Layer Properties" URL="\ref map_layer_properties"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Gets maximum zoom at which the layer will be displayed.
        /// </summary>
        /// <param name="layerHandle"></param>
        /// <returns></returns>
        /// <remarks>It's analogous to get_LayerMaxVisibleScale, only scale specified as zoom level 
        /// of the current tile provider (Map.Tiles.Provider).</remarks>
        /// \new491 Added in version 4.9.1
        public int get_LayerMaxVisibleZoom(int layerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets maximum zoom at which the layer will be displayed.
        /// </summary>
        /// <param name="layerHandle">Layer handle.</param>
        /// <param name="param0">The new value of max zoom.</param>
        /// <remarks>It's analogous to set_LayerMaxVisibleScale, only scale specified as zoom level 
        /// of the current tile provider (Map.Tiles.Provider).</remarks>
        /// \new491 Added in version 4.9.1
        public void set_LayerMaxVisibleZoom(int layerHandle, int param0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets filename of datasource for the specified layer.
        /// </summary>
        /// <param name="layerHandle">Layer handle.</param>
        /// <returns>Filename of the layer including path.</returns>
        /// \new490 Added in version 4.9.0
        public string get_LayerFilename(int layerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets minimum zoom at which the layer will be displayed.
        /// </summary>
        /// <param name="layerHandle"></param>
        /// <returns></returns>
        /// <remarks>It's analogous to get_LayerMinVisibleScale, only scale specified as zoom level 
        /// of the current tile provider (Map.Tiles.Provider).</remarks>
        /// \new491 Added in version 4.9.1
        public int get_LayerMinVisibleZoom(int layerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets minimum zoom at which the layer will be displayed.
        /// </summary>
        /// <param name="layerHandle">Layer handle.</param>
        /// <param name="param0">The new value of max zoom.</param>
        /// <remarks>It's analogous to set_LayerMinVisibleScale, only scale specified as zoom level 
        /// of the current tile provider (Map.Tiles.Provider).</remarks>
        /// \new491 Added in version 4.9.1
        public void set_LayerMinVisibleZoom(int layerHandle, int param0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the description of the layer.
        /// </summary>
        /// <remarks>The information will be stored in .mwsymb file associated with data layer.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The description of the layer.</param>
        /// \new48 Added in version 4.8
        public void set_LayerDescription(int LayerHandle, string __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the description of the layer from the associated .mwsymb file.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The string with description.</returns>
        /// \new48 Added in version 4.8
        public string get_LayerDescription(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the boolean value which indicates whether the layer will be displayed at all scales or only within the chosen range of scales.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>True in case the layer will be displayed between specified scales only.</returns>
        /// \see AxMap.get_LayerMaxVisibleScale, AxMap.get_LayerMinVisibleScale
        /// \new48 Added in version 4.8
        public bool get_LayerDynamicVisibility(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the boolean value which indicates whether the layer will be displayed at all scales or only within the chosen range of scales.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">True in case the layer will be displayed between specified scales only.</param>
        /// \see set_LayerMaxVisibleScale, set_LayerMinVisibleScale
        /// \new48 Added in version 4.8
        public void set_LayerDynamicVisibility(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a string associated with a layer in the map. 
        /// </summary>
        /// <remarks>This string can be used to store any string data desired by the developer.</remarks>
        /// <param name="LayerHandle">The handle for the layer for which the layer key is to be set.</param>
        /// <returns>The layer key for the specified layer in string format.</returns>
        public string get_LayerKey(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a string associated with a layer in the map. 
        /// </summary>
        /// <remarks>This string can be used to store any string data desired by the developer.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The string to be associated with layer.</param>
        public void set_LayerKey(int LayerHandle, string __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns labels associated with layer.
        /// </summary>
        /// <remarks>Labels can also be obtained by using Shapefile.Labels and Image.Labels.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The labels associated with the layer.</returns>
        /// \new48 Added in version 4.8
        public MapWinGIS.Labels get_LayerLabels(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the labels associated with the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The new instance of the Labels class to be associated with the layer.</param>
        /// \new48 Added in version 4.8
        public void set_LayerLabels(int LayerHandle, MapWinGIS.Labels __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the maximum scale at which the layer is visible on the map.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The maximum visible scale for the layer.</returns>
        /// \new48 Added in version 4.8
        public double get_LayerMaxVisibleScale(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the maximum scale at which the layer is visible on the map.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The maximum visible scale for the layer.</param>
        /// \new48 Added in version 4.8
        public void set_LayerMaxVisibleScale(int LayerHandle, double __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the minimum scale at which the layer is visible on the map.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The minimum visible scale for the layer.</returns>
        /// \new48 Added in version 4.8
        public double get_LayerMinVisibleScale(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the minimum scale at which the layer is visible on the map.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The minimum visible scale for the layer.</param>
        /// \new48 Added in version 4.8
        public void set_LayerMinVisibleScale(int LayerHandle, double __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the name of the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the name is to be set.</param>
        /// <returns>The layer name for the specified layer. </returns>
        public string get_LayerName(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the name of the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the name is to be set.</param>
        /// <param name="__p2">The name to be set for the layer.</param>
        public void set_LayerName(int LayerHandle, string __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a boolean value which indicates whether the layer will be serialized by appropriate routines.
        /// </summary>
        /// <remarks>This property affects AxMap.SaveMapState, AxMap.SerializeMapState.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>True in case the layer will be excluded from serialization and false otherwise.</returns>
        /// \new48 Added in version 4.8
        public bool get_LayerSkipOnSaving(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether the layer will be serialized by appropriate routines.
        /// </summary>
        /// <remarks>This property affects AxMap.SaveMapState, AxMap.SerializeMapState.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">True in case the layer will be excluded from serialization and false otherwise.</param>
        /// \new48 Added in version 4.8
        public void set_LayerSkipOnSaving(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the visibility of the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the visibility is being set. </param>
        /// <returns>A boolean value representing whether the layer is to be visible or not.</returns>
        public bool get_LayerVisible(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the visibility of the specified layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer for which the visibility is returned. </param>
        /// <param name="__p2">A boolean value representing whether the layer is to be visible or not.</param>
        public void set_LayerVisible(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }
       
        /// @}

        #endregion

        #region Layer management
        /// \addtogroup map_layer_management Layer management
        /// Here is a list of properties and methods which allow to work with layers of the map. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_layer {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Layer Management" URL="\ref map_layer_management"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Removes all data from the map and sets its properties to the default state.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a layer from spatial database accessed via GDAL/OGR drivers.
        /// </summary>
        /// <remarks>This method will search if there is a layer with specified name in the datasource,
        /// and if so will open it. Otherwise it will run OgrDatasource.RunQuery method with provided
        /// layerNameOrQuery argument. 
        /// Additional information on failure can be obtained through AxMap.FileManager property.</remarks>
        /// <param name="connectionString">Connection string. See details for particular formats <a href ="http://www.gdal.org/ogr_formats.html">here</a>.</param>
        /// <param name="layerNameOrQuery">Name of the layer (i.e. database table) or SQL query.</param>
        /// <param name="visible">A value indicating whether a new layer will be visible.</param>
        /// <returns>Handle of the newly added layer or -1 on failure.</returns>
        /// \new492b Added in version 4.9.2
        public int AddLayerFromDatabase(string connectionString, string layerNameOrQuery, bool visible);

        /// <summary>
        /// Adds layer from the specified datasource.
        /// </summary>
        /// <remarks>Additional information on failure can be obtained through AxMap.FileManager property.</remarks>
        /// <param name="filename">Filename of datasource</param>
        /// <param name="openStrategy">Open strategy (fosAutoDetect the default recommended value).</param>
        /// <param name="visible">A value indicating whether a new layer will be visible.</param>
        /// <returns>Handle of the newly added layer or -1 on failure.</returns>
        /// \new491 Added in version 4.9.1
        public int AddLayerFromFilename(string filename, tkFileOpenStrategy openStrategy, bool visible)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a layer to the map.
        /// </summary>
        /// <param name="Object">The object (either Image or Shapefile) to add to the map.</param>
        /// <param name="Visible">Sets whether the layer is visible after being added to the map.</param>
        /// <returns>Returns the integer handle for the layer added to the map.</returns>
        public int AddLayer(object Object, bool Visible)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the handle of the layer at the given position in the map. Returns -1 if there is no layer at the specified position
        /// </summary>
        /// <param name="LayerPosition">The position of the layer for which the layer handle is required.</param>
        /// <returns>The layer handle for the layer at the specified position.</returns>
        public int get_LayerHandle(int LayerPosition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the position of the specified layer in the map.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the layer position is required.</param>
        /// <returns>The layer position of the specified layer in the map.</returns>
        public int get_LayerPosition(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves a layer in the map from the initial position to a target position.
        /// </summary>
        /// <param name="InitialPosition">The initial position of the layer to be moved.</param>
        /// <param name="TargetPosition">The final position of the layer being moved.</param>
        /// <returns></returns>
        public bool MoveLayer(int InitialPosition, int TargetPosition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the specified layer below all other layers.
        /// </summary>
        /// <param name="InitialPosition">The position of the layer to move to the bottom</param>
        /// <returns>Boolean value representing success when true, and failure when false.</returns>
        public bool MoveLayerBottom(int InitialPosition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the specified layer down one layer in the map.
        /// </summary>
        /// <param name="InitialPosition">The position of the layer to be moved.</param>
        /// <returns>Boolean value representing success when true, and failure when false.</returns>
        public bool MoveLayerDown(int InitialPosition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the specified layer to the top of all other layers.
        /// </summary>
        /// <param name="InitialPosition">The position of the layer to be moved.</param>
        /// <returns>Boolean value representing success when true, failure when false.</returns>
        public bool MoveLayerTop(int InitialPosition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the specified layer up one layer in the map.
        /// </summary>
        /// <param name="InitialPosition">The initial position of the layer to be moved.</param>
        /// <returns>Boolean value representing success when true, failure when false.</returns>
        public bool MoveLayerUp(int InitialPosition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of layers loaded in the map.
        /// </summary>
        public int NumLayers
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Removes all layers from the map.
        /// </summary>
        public void RemoveAllLayers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the data source for the specified layer without its closing.
        /// </summary>
        /// <remarks>The new data source must be of the same type, i.e. either Shapefile or Image.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="newSrcPath">The the name of the new data source.</param>
        public void ReSourceLayer(int LayerHandle, string newSrcPath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified layer from the map
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer to be removed from the map.</param>
        public void RemoveLayer(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes layer from the map without its closing.
        /// </summary>
        /// <remarks>Shapefile.Close or Image.Close won't be called while removing the layer.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        public void RemoveLayerWithoutClosing(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets image object associated with the layer.
        /// </summary>
        /// <remarks>This method along with AxMap.get_Shapefile() can used to substitute AxMap.get_GetObject().</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The reference to the image or NULL reference in case of invalid handle or wrong layer type.</returns>
        /// \new48 Added in version 4.8
        public Image get_Image(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replaces the image object associated with the layer.
        /// </summary>
        /// <remarks>The old image will not be closed.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The new image object.</param>
        /// \new48 Added in version 4.8
        public void set_Image(int LayerHandle, Image __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets shapefile object associated with the layer.
        /// </summary>
        /// <remarks>This method along with AxMap.get_Image() can be used to substitute AxMap.get_GetObject().</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>The reference to the shapefile or NULL reference in case of invalid handle or wrong layer type.</returns>
        /// \new48 Added in version 4.8
        public Shapefile get_Shapefile(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replaces the shapefile object associated with the layer.
        /// </summary>
        /// <remarks>The old shapefile will not be closed.</remarks>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="__p2">The new shapefile object.</param>
        /// \new48 Added in version 4.8
        public void set_Shapefile(int LayerHandle, Shapefile __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the layer object with the given handle. The object could be a Shapefile, Grid, or Image object.
        /// </summary>
        /// <remarks>For OGR layers this method will return underlying shapefile from OgrLayer.GetData(). 
        /// Use AxMap.get_OgrLayer to access instance of OgrLayer itself.</remarks>
        /// <param name="LayerHandle">The handle of the layer to be retrieved.</param>
        /// <returns>A Shapefile, Grid, or Image object.</returns>
        public object get_GetObject(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets instance of OGR layer object associated with the specified layer.
        /// </summary>
        /// <param name="layerHandle">The handle of the layer.</param>
        /// <returns>OGR layer or null in case of invalid layer index or wrong layer type.</returns>
        /// \new492b Added in version 4.9.2
        public OgrLayer get_OgrLayer(int layerHandle);

        /// @}
        #endregion

        #region Drawing layer
        /// \addtogroup map_drawing_layers Drawing layers
        /// Here is a list of methods and properties to interact with the drawing layers of the map. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_drawing_layers {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Drawing Layers" URL="\ref map_drawing_layers"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Clears all the drawings on the drawing layer specified.
        /// </summary>
        /// <param name="DrawHandle">Drawing handle of the drawing layer for which all drawings are to be cleared.</param>
        public void ClearDrawing(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears all drawings on all drawing layers. This method is slower than using ClearDrawing on a specific layer
        /// </summary>
        public void ClearDrawings()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a circle on the last drawing layer created by NewDrawing
        /// </summary>
        /// <param name="x">Center x coordinate for the circle to be drawn.</param>
        /// <param name="y">Center y coordinate for the circle to be drawn.</param>
        /// <param name="pixelRadius">Radius in pixels of the circle to be drawn.</param>
        /// <param name="Color">Color of the circle to be drawn. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">Boolean value which determines whether the circle will be drawn with a fill or not.</param>
        public void DrawCircle(double x, double y, double pixelRadius, uint Color, bool fill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a circle on the specified drawing layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer created with AxMap.NewDrawing call.</param>
        /// <param name="x">Center x coordinate for the circle to be drawn.</param>
        /// <param name="y">Center y coordinate for the circle to be drawn.</param>
        /// <param name="pixelRadius">Radius in pixels of the circle to be drawn.</param>
        /// <param name="Color">Color of the circle to be drawn. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">Boolean value which determines whether the circle will be drawn with a fill or not.</param>
        public void DrawCircleEx(int LayerHandle, double x, double y, double pixelRadius, uint Color, bool fill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a line on the last drawing layer created using NewDrawing.
        /// </summary>
        /// <param name="x1">X coordinate of the first point used to draw the line</param>
        /// <param name="y1">Y coordinate of the first point used to draw the line.</param>
        /// <param name="x2">X coordinate of the second point used to draw the line.</param>
        /// <param name="y2">Y coordinate of the second point used to draw the line.</param>
        /// <param name="pixelWidth">Width of the line in pixels.</param>
        /// <param name="Color">Color to draw the line with. This is a UInt32 representation of an RGB value.</param>
        public void DrawLine(double x1, double y1, double x2, double y2, int pixelWidth, uint Color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a line on the specified drawing layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer created with AxMap.NewDrawing call.</param>
        /// <param name="x1">X coordinate of the first point used to draw the line</param>
        /// <param name="y1">Y coordinate of the first point used to draw the line.</param>
        /// <param name="x2">X coordinate of the second point used to draw the line.</param>
        /// <param name="y2">Y coordinate of the second point used to draw the line.</param>
        /// <param name="pixelWidth">Width of the line in pixels.</param>
        /// <param name="Color">Color to draw the line with. This is a UInt32 representation of an RGB value.</param>
        public void DrawLineEx(int LayerHandle, double x1, double y1, double x2, double y2, int pixelWidth, uint Color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a point on the last drawing layer created by NewDrawing.
        /// </summary>
        /// <param name="x">The x coordinate of the point to draw</param>
        /// <param name="y">The y coordinate of the point to draw.</param>
        /// <param name="pixelSize">The size in pixels of the point to be drawn.</param>
        /// <param name="Color">The color of the point to be drawn. This is a UInt32 representation of an RGB color.</param>
        public void DrawPoint(double x, double y, int pixelSize, uint Color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a point on the specified drawing layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer created with AxMap.NewDrawing call.</param>
        /// <param name="x">The x coordinate of the point to draw</param>
        /// <param name="y">The y coordinate of the point to draw.</param>
        /// <param name="pixelSize">The size in pixels of the point to be drawn.</param>
        /// <param name="Color">The color of the point to be drawn. This is a UInt32 representation of an RGB color.</param>
        public void DrawPointEx(int LayerHandle, double x, double y, int pixelSize, uint Color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a polygon on the last drawing layer created using NewDrawing.
        /// </summary>
        /// <param name="xPoints">An array containing x-coordinates for each point in the polygon.</param>
        /// <param name="yPoints">An array containing y-coordinates for each point in the polygon.</param>
        /// <param name="numPoints">The number of points in the polygon.</param>
        /// <param name="Color">The color to use when drawing the polygon. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">A boolean value representing whether the polygon is drawn with a fill or not.</param>
        public void DrawPolygon(ref object xPoints, ref object yPoints, int numPoints, uint Color, bool fill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a polygon on the specified drawing layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer created with AxMap.NewDrawing call.</param>
        /// <param name="xPoints">An array containing x-coordinates for each point in the polygon.</param>
        /// <param name="yPoints">An array containing y-coordinates for each point in the polygon.</param>
        /// <param name="numPoints">The number of points in the polygon.</param>
        /// <param name="Color">The color to use when drawing the polygon. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">A boolean value representing whether the polygon is drawn with a fill or not.</param>
        public void DrawPolygonEx(int LayerHandle, ref object xPoints, ref object yPoints, int numPoints, uint Color, bool fill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a circle with custom outline width on the last drawing layer created by NewDrawing.
        /// </summary>
        /// <param name="x">Center x coordinate for the circle to be drawn.</param>
        /// <param name="y">Center y coordinate for the circle to be drawn.</param>
        /// <param name="pixelRadius">Radius in pixels of the circle to be drawn.</param>
        /// <param name="Color">Color of the circle to be drawn. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">Boolean value which determines whether the circle will be drawn with a fill or not.</param>
        /// <param name="Width">The width of the outline.</param>
        public void DrawWideCircle(double x, double y, double pixelRadius, uint Color, bool fill, short Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a circle with custom outline width on the specified drawing layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer created with AxMap.NewDrawing call.</param>
        /// <param name="x">Center x coordinate for the circle to be drawn.</param>
        /// <param name="y">Center y coordinate for the circle to be drawn.</param>
        /// <param name="radius">Radius in pixels of the circle to be drawn.</param>
        /// <param name="Color">Color of the circle to be drawn. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">Boolean value which determines whether the circle will be drawn with a fill or not.</param>
        /// <param name="OutlineWidth">The width of the outline.</param>
        public void DrawWideCircleEx(int LayerHandle, double x, double y, double radius, uint Color, bool fill, short OutlineWidth)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a polygon with custom width of outline on the last drawing layer created using NewDrawing.
        /// </summary>
        /// <param name="xPoints">An array containing x-coordinates for each point in the polygon.</param>
        /// <param name="yPoints">An array containing y-coordinates for each point in the polygon.</param>
        /// <param name="numPoints">The number of points in the polygon.</param>
        /// <param name="Color">The color to use when drawing the polygon. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">A boolean value representing whether the polygon is drawn with a fill or not.</param>
        /// <param name="Width">The width of the outline.</param>
        public void DrawWidePolygon(ref object xPoints, ref object yPoints, int numPoints, uint Color, bool fill, short Width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a polygon with custom width of outline on the last drawing layer created using NewDrawing.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer created with AxMap.NewDrawing call.</param>
        /// <param name="xPoints">An array containing x-coordinates for each point in the polygon.</param>
        /// <param name="yPoints">An array containing y-coordinates for each point in the polygon.</param>
        /// <param name="numPoints">The number of points in the polygon.</param>
        /// <param name="Color">The color to use when drawing the polygon. This is a UInt32 representation of an RGB color.</param>
        /// <param name="fill">A boolean value representing whether the polygon is drawn with a fill or not.</param>
        /// <param name="OutlineWidth">The width of the outline.</param>
        public void DrawWidePolygonEx(int LayerHandle, ref object xPoints, ref object yPoints, int numPoints, uint Color, bool fill, short OutlineWidth)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new drawing layer on the map returning its handle.
        /// </summary>
        /// <param name="Projection">Sets the coordinate system to use for the new drawing layer to be created. (ScreenReferenced 
        /// uses pixels in screen coordinates. SpatiallyReferenced uses projected map units.)</param>
        /// <returns>The handle for the new drawing layer in the map.</returns>
        public int NewDrawing(MapWinGIS.tkDrawReferenceList Projection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the drawing key which may be used by the programmer to store any string for a drawing layer with specified handle.
        /// </summary>
        /// <param name="DrawHandle">The handle of the drawing layer.</param>
        /// <returns>The string associated with the layer.</returns>
        public string get_DrawingKey(int DrawHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the drawing key may be used by the programmer to store any string for a drawing layer with specified handle.
        /// </summary>
        /// <param name="DrawHandle">The handle of the drawing layer.</param>
        /// <param name="__p2">The string associated with the layer.</param>
        public void set_DrawingKey(int DrawHandle, string __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the boolean value which indicates whether the labels of the drawing layer are visible.
        /// </summary>
        /// <param name="LayerHandle">The handle of the drawing layer.</param>
        /// <param name="Visible">A boolean value which indicates whether the labels are visible.</param>
        public void SetDrawingLayerVisible(int LayerHandle, bool Visible)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Affects the scaling of the labels of the specified drawing layer.
        /// </summary>
        /// <param name="DrawHandle">The handle of the drawing layer.</param>
        /// <param name="Width">The width in pixels.</param>
        /// \deprecated v.4.8. Use Labels.BasicScale and Labels.ScaleLabels instead.
        public void SetDrawingStandardViewWidth(int DrawHandle, double Width)
        {
            throw new NotImplementedException();
        }

        /// @}
        #endregion

        #region Shape properties
        /// \addtogroup map_shape_properties Shape properties
        /// Here is a list of properties for changing appearance of individual shapes of shapefile layer added to the map. 
        /// The properties listed here are deprecated.
        /// This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_shape_properties {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = gray, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Shape properties" URL="\ref map_shape_properties"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{
        
        /// <summary>
        /// Deprecated. Gets whether the specified shape is drawn with a fill. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the fill is to be set.</param>
        /// <returns>Sets whether the shape is drawn with a fill or not.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillVisible property. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public bool get_ShapeDrawFill(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets whether the specified shape is drawn with a fill. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill is to be set. </param>
        /// <param name="Shape">Handle of the shape for which the fill is to be set.</param>
        /// <param name="__p3">Sets whether the shape is drawn with a fill or not. </param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillVisible property. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeDrawFill(int LayerHandle, int Shape, bool __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets whether the lines for the specified shape are drawn.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the lines are to be set.</param>
        /// <param name="Shape">Handle of the shape for which the lines are to be set.</param>
        /// <returns>Sets whether the shape is drawn with lines or not.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineVisible instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public bool get_ShapeDrawLine(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets whether the lines for the specified shape are drawn.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the lines are to be set.</param>
        /// <param name="Shape">Handle of the shape for which the lines are to be set. </param>
        /// <param name="__p3">Sets whether the shape is drawn with lines or not.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineVisible instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeDrawLine(int LayerHandle, int Shape, bool __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets whether the points/vertices in specified shape are drawn.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the points are to be set.</param>
        /// <param name="Shape">Handle of the shape for which the points are to be set.</param>
        /// <returns>Sets whether the shape is drawn with points or not.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.Visible instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public bool get_ShapeDrawPoint(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets whether the points/vertices in specified shape are drawn. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the points are to be set.</param>
        /// <param name="Shape">Handle of the shape for which the points are to be set.</param>
        /// <param name="__p3">Sets whether the shape is drawn with points or not.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.Visible instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeDrawPoint(int LayerHandle, int Shape, bool __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the fill color for the specified shape. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill color is to be set.</param>
        /// <param name="Shape">Handle for the shape for which the fill color is to be set.</param>
        /// <returns>Fill color for the shape in the polygon shapefile. This is a System.UInt32 representation of an RGB color.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillColor instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public uint get_ShapeFillColor(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the fill color for the specified shape. Only works on polygon shapefiles
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill color is to be set.</param>
        /// <param name="Shape">Handle for the shape for which the fill color is to be set. </param>
        /// <param name="__p3">Fill color for the shape in the polygon shapefile. This is a System.UInt32 representation of an RGB color</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillColor instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeFillColor(int LayerHandle, int Shape, uint __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the fill stipple for the specified shape. Only works on polygon shapefiles
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill stipple is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the fill stipple is required.</param>
        /// <returns>Gets the fill stipple for the specified shape.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillHatchStyle instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public MapWinGIS.tkFillStipple get_ShapeFillStipple(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the fill stipple for the specified shape. Only works on polygon shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill stipple is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the fill stipple is to be set.</param>
        /// <param name="__p3">Sets fill stipple for the specified shape.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillHatchStyle instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeFillStipple(int LayerHandle, int Shape, MapWinGIS.tkFillStipple __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the percentage of fill transparency for the specified layer. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill transparency is to be set. </param>
        /// <param name="Shape">Handle of the shape for which the fill transparency is to be set.</param>
        /// <returns>Gets the percentage of fill transparency for the specified shape.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillTransparency instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public float get_ShapeFillTransparency(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the percentage of fill transparency for the specified layer. Only works on polygon shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the fill transparency is to be set. </param>
        /// <param name="Shape">Handle of the shape for which the fill transparency is to be set. </param>
        /// <param name="__p3">Sets the percentage of fill transparency for the specified shape. </param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillTransparency instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeFillTransparency(int LayerHandle, int Shape, float __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the line color for the specified shape. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the line color is required.</param>
        /// <param name="Shape">Handle of the shape for which the line color is required.</param>
        /// <returns>Line color for the shape in the polygon shapefile.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineColor instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public uint get_ShapeLineColor(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the line color for the specified shape. Only works on shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the line color is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the line color is to be set.</param>
        /// <param name="__p3">Line color for the shape in the polygon shapefile. This is a System.UInt32 representation of an RGB color</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineColor instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeLineColor(int LayerHandle, int Shape, uint __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the line stipple for the specified shape. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the line stipple is required.</param>
        /// <param name="Shape">Handle of the shape for which the line stipple is required.</param>
        /// <returns>Line stipple for the shape in the shapefile. </returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineStipple instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public MapWinGIS.tkLineStipple get_ShapeLineStipple(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the line stipple for the specified shape. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the line stipple is to be set. </param>
        /// <param name="Shape">Handle of the shape for which the line stipple is to be set.</param>
        /// <param name="__p3">Line stipple for the shape in the shapefile.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineStipple instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeLineStipple(int LayerHandle, int Shape, MapWinGIS.tkLineStipple __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the line width for the specified shape. Only works on shapefiles.
        /// Suggested values for line width: 1 - 5
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line width is required. </param>
        /// <param name="Shape">Handle of the shape for which the line width is required.</param>
        /// <returns>Line width for the shape in the shapefile.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineWidth instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public float get_ShapeLineWidth(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the line width for the specified shape. Only works on shapefiles.
        /// Suggested values for line width: 1 - 5
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the line width is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the line width is to be set</param>
        /// <param name="__p3">Line width for the shape in the shapefile.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.LineWidth instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeLineWidth(int LayerHandle, int Shape, float __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the point color for the specified shape. Only works on shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the point color is required. </param>
        /// <param name="Shape">Handle of the shape for which the point color is required.</param>
        /// <returns>Point color for the shape in the polygon shapefile.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillColor for point shapefiles and ShapeDrawingOptions.VerticesColor  
        /// for polylines and polygons instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public uint get_ShapePointColor(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the point color for the specified shape. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the point color is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the point color is to be set. </param>
        /// <param name="__p3">Point color for the shape in the polygon shapefile. This is a System.UInt32 representation of an RGB color</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillColor for point shapefiles and ShapeDrawingOptions.VerticesColor  
        /// for polylines and polygons instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapePointColor(int LayerHandle, int Shape, uint __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the index of the point marker represented by font character.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="Shape">The index of the shape.</param>
        /// <returns>The index of the marker associated with shape.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.PointCharacter instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public int get_ShapePointFontCharListID(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the index of the point marker represented by font character.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="Shape">The index of the shape.</param>
        /// <param name="__p3">The index of the marker associated with shape.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.PointCharacter instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapePointFontCharListID(int LayerHandle, int Shape, int __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows you specify an image from the image list so that one point shapefile can have multiple icons.
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer for which the image list is defined. </param>
        /// <param name="Shape">The specific shape in the layer that you wish to determine the image index for</param>
        /// <returns>The index in the image list of user defined images.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.Picture instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public int get_ShapePointImageListID(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows you specify an image from the image list so that one point shapefile can have multiple icons
        /// </summary>
        /// <param name="LayerHandle">The layer handle of the layer containing the list to specify an image from.</param>
        /// <param name="Shape">The specific shape to be assigned a value in the layer. </param>
        /// <param name="__p3">The index of the image in the imagelist that you want to assign to the specified shape</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.Picture instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapePointImageListID(int LayerHandle, int Shape, int __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the line point/vertex size for the specified shape. Only works on shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the point/vertex size is required. </param>
        /// <param name="Shape">Handle of the shape for which the point/vertex size is required</param>
        /// <returns>Point/vertex size for the shape in the shapefile.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.PointSize instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public float get_ShapePointSize(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the line point/vertex size for the specified shape. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the point/vertex size is to be set.</param>
        /// <param name="Shape">Handle of the shape for which the point/vertex size is to be set.</param>
        /// <param name="__p3">Point/vertex size for the shape in the shapefile.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.PointSize instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapePointSize(int LayerHandle, int Shape, float __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the line point type for the specified shape. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the point type is to be set. </param>
        /// <param name="Shape">Handle of the shape for which the point type is to be set.</param>
        /// <param name="__p3">Point type for the shape in the shapefile.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.PointType instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapePointType(int LayerHandle, int Shape, MapWinGIS.tkPointType __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the line point type for the specified shape. Only works on shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the point type is required. </param>
        /// <param name="Shape">Handle of the shape for which the point type is required. </param>
        /// <returns>Point type for the shape in the shapefile.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.PointType instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public MapWinGIS.tkPointType get_ShapePointType(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets the color of the polygon fill stipple for the given shape of the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="Shape">The index of the shape.</param>
        /// <returns>The color of stipple.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillHatchStyle instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public uint get_ShapeStippleColor(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the color of the polygon fill stipple for the given shape of the layer.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="Shape">The index of the shape.</param>
        /// <param name="__p3">The color of stipple.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillHatchStyle instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeStippleColor(int LayerHandle, int Shape, uint __p3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Gets a boolean value which indicates whether the background of fill stipple for given shape of will be transparent.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="Shape">The index of the shape.</param>
        /// <returns>True in case the background is transparent and false otherwise.</returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillBgTransparent instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public bool get_ShapeStippleTransparent(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets a boolean value which indicates whether the background of fill stipple for given shape of will be transparent.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <param name="Shape">The index of the shape.</param>
        /// <param name="__p3">True in case the background is transparent and false otherwise.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.FillBgTransparent instead. See ShapefileCategories, Shapefile.set_ShapeCategory to setup 
        /// visualization of individual shapes.
        public void set_ShapeStippleTransparent(int LayerHandle, int Shape, bool __p3)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Deprecated. Gets the visibility of the specified shape.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the visibility is required.</param>
        /// <param name="Shape">Handle of the shape for which the visibility is required.</param>
        /// <returns>Boolean value representing whether the the shape is visible or not. </returns>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.Visible and Shapefile.VisibilityExpression instead. 
        /// See ShapefileCategories, Shapefile.set_ShapeCategory to setup visualization of individual shapes.
        public bool get_ShapeVisible(int LayerHandle, int Shape)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deprecated. Sets the visibility of the specified shape. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer containing the shape for which the visibility is to be set</param>
        /// <param name="Shape">Handle of the shape for which the visibility is to be set.</param>
        /// <param name="__p3">Boolean value representing whether the shape is to be visible or not.</param>
        /// \deprecated v. 4.8. Use ShapeDrawingOptions.Visible and Shapefile.VisibilityExpression instead. 
        /// See ShapefileCategories, Shapefile.set_ShapeCategory to setup visualization of individual shapes.
        public void set_ShapeVisible(int LayerHandle, int Shape, bool __p3)
        {
            throw new NotImplementedException();
        }

        /// @}
        #endregion

        #region Shapefile layer
        /// \addtogroup map_shapefile Shapefile visualization
        /// Here is a list of properties for changing appearance of shapefile layer added to the map. 
        /// Consider the usage of ShapeDrawingOptions class to access wider set of options. 
        /// See Shapefile.DefaultDrawingOptions for details. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_shapefile {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Shapefile visualization" URL="\ref map_shapefile"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Gets whether the specified layer is drawn with a fill. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill is to be set.</param>
        /// <returns>Gets whether the layer is being drawn with a fill or not.</returns>
        public bool get_ShapeLayerDrawFill(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets whether the specified layer is drawn with a fill. Only works on polygon shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill is to be set. </param>
        /// <param name="__p2">Sets whether the layer is drawn with a fill or not.</param>
        public void set_ShapeLayerDrawFill(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets whether the lines for the shapefile in specified layer are drawn. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer to test if it is being drawn with a lines or not.</param>
        /// <returns>Gets whether the layer is being drawn with lines or not.</returns>
        public bool get_ShapeLayerDrawLine(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets whether the lines for the shapefile in specified layer are drawn. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the lines are to be set.</param>
        /// <param name="__p2">Sets whether the layer is drawn with lines or not.</param>
        public void set_ShapeLayerDrawLine(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets whether the points/vertices for the shapefile in specified layer are drawn. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer to test if it is being drawn with a points or not.</param>
        /// <returns>Gets whether the layer is being drawn with points or not.</returns>
        public bool get_ShapeLayerDrawPoint(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets whether the points/vertices for the shapefile in specified layer are drawn.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the points are to be set.</param>
        /// <param name="__p2">Sets whether the layer is drawn with points or not.</param>
        public void set_ShapeLayerDrawPoint(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the fill color for the specified layer. Only works on polygon shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill color is required. </param>
        /// <returns>Fill color for the polygon shapefile.</returns>
        public uint get_ShapeLayerFillColor(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the fill color for the specified layer. Only works on polygon shapefiles
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill color is to be set.</param>
        /// <param name="__p2">Fill color for the polygon shapefile. This is a System.UInt32 representation of an RGB color.</param>
        public void set_ShapeLayerFillColor(int LayerHandle, uint __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the fill stipple for the specified layer. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill stipple is required. </param>
        /// <returns>Gets the fill stipple for the specified layer.</returns>
        public MapWinGIS.tkFillStipple get_ShapeLayerFillStipple(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the fill stipple for the specified layer. Only works on polygon shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill stipple is to be set.</param>
        /// <param name="__p2">Sets fill stipple for the specified layer.</param>
        public void set_ShapeLayerFillStipple(int LayerHandle, MapWinGIS.tkFillStipple __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the percentage of fill transparency for the specified layer. Only works on polygon shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer to get percentage of fill transparency. </param>
        /// <returns>Gets the percentage of fill transparency for the specified layer.</returns>
        public float get_ShapeLayerFillTransparency(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the percentage of fill transparency for the specified layer. Only works on polygon shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the fill transparency is to be set. </param>
        /// <param name="__p2">Sets the percentage of fill transparency for the specified layer.</param>
        public void set_ShapeLayerFillTransparency(int LayerHandle, float __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the line color for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line color is required. </param>
        /// <returns>Line color for the polygon shapefile. </returns>
        public uint get_ShapeLayerLineColor(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the line color for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line color is to be set.</param>
        /// <param name="__p2">Line color for the polygon shapefile. This is a System.UInt32 representation of an RGB color.</param>
        public void set_ShapeLayerLineColor(int LayerHandle, uint __p2)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets the line stipple for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line stipple is required.</param>
        /// <returns>Line stipple for the shapefile.</returns>
        public MapWinGIS.tkLineStipple get_ShapeLayerLineStipple(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the line stipple for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line stipple is required.</param>
        /// <param name="__p2">Line stipple for the shapefile.</param>
        public void set_ShapeLayerLineStipple(int LayerHandle, MapWinGIS.tkLineStipple __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the line width for the specified layer. Only works on shapefiles.
        /// Suggested values for line width: 1 - 5
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line width is required.</param>
        /// <returns>Line width for the shapefile.</returns>
        public float get_ShapeLayerLineWidth(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the line width for the specified layer. Only works on shapefiles.
        /// Suggested values for line width: 1 - 5
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the line width is to be set.</param>
        /// <param name="__p2">Line width for the shapefile.</param>
        public void set_ShapeLayerLineWidth(int LayerHandle, float __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the point color for the specified layer. Only works on shapefiles
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the point color is required. </param>
        /// <returns>Point color for the polygon shapefile. </returns>
        public uint get_ShapeLayerPointColor(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the point color for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the point color is to be set.</param>
        /// <param name="__p2">Point color for the polygon shapefile. This is a System.UInt32 representation of an RGB color.</param>
        public void set_ShapeLayerPointColor(int LayerHandle, uint __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the line point/vertex size for the specified layer. Only works on shapefiles. 
        /// </summary>
        /// <param name="LayerHandle">Gets or sets the line point/vertex size for the specified layer. Only works on shapefiles. </param>
        /// <returns>Point/vertex size for the shapefile. </returns>
        public float get_ShapeLayerPointSize(int LayerHandle)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets the line point/vertex size for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the point/vertex size is to be set.</param>
        /// <param name="__p2">Point/vertex size for the shapefile.</param>
        public void set_ShapeLayerPointSize(int LayerHandle, float __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the line point type for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the point type is required.</param>
        /// <returns>%Point type for the shapefile.</returns>
        public MapWinGIS.tkPointType get_ShapeLayerPointType(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the line point type for the specified layer. Only works on shapefiles.
        /// </summary>
        /// <param name="LayerHandle">Handle of the layer for which the point type is to be set.</param>
        /// <param name="__p2">%Point type for the shapefile.</param>
        public void set_ShapeLayerPointType(int LayerHandle, MapWinGIS.tkPointType __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the color of the polygon stipple for shapefile layer.
        /// </summary>
        /// <remarks>This property corresponds to the ShapeDrawingOptions.FillHatchStyle property.</remarks>
        /// <param name="LayerHandle">The handle of the shapefile layer.</param>
        /// <returns>The color of stipple.</returns>
        public uint get_ShapeLayerStippleColor(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the color of the polygon stipple for shapefile layer.
        /// </summary>
        /// <remarks>This property corresponds to the ShapeDrawingOptions.FillBgTransparent property.</remarks>
        /// <remarks>This property corresponds to the ShapeDrawingOptions.FillHatchStyle property.</remarks>
        /// <param name="LayerHandle">The handle of the shapefile layer.</param>
        /// <param name="__p2">The color of stipple.</returns>
        /// \see Shapefile.DefaultDrawingOptions
        public void set_ShapeLayerStippleColor(int LayerHandle, uint __p2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a boolean value which indicates whether the background of fill stipple for polygon shapefile layer will be transparent.
        /// </summary>
        /// <remarks>This property corresponds to the ShapeDrawingOptions.FillBgTransparent property.</remarks>
        /// <param name="LayerHandle">The handle of the shapefile layer.</param>
        /// <returns>True in case the background is transparent and false otherwise.</returns>
        public bool get_ShapeLayerStippleTransparent(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a boolean value which indicates whether the background of fill stipple for polygon shapefile layer will be transparent.
        /// </summary>
        /// <remarks>This property corresponds to the ShapeDrawingOptions.FillBgTransparent property.</remarks>
        /// <param name="LayerHandle">The handle of the shapefile layer.</param>
        /// <param name="__p2">True in case the background is transparent and false otherwise.</param>
        public void set_ShapeLayerStippleTransparent(int LayerHandle, bool __p2)
        {
            throw new NotImplementedException();
        }

        /// @}

        #endregion

        #region Map extents
        /// \addtogroup map_extents Max extents and zoom
        /// Here is list of properties and methods that affect map extents and zoom level. This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_extents {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Map extents adn zoom" URL="\ref map_extents"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>
        /// @{

        /// <summary>
        /// Sets geographic extents for the map.
        /// </summary>
        /// <param name="xLongitude">Longitude of center of the screen (degrees).</param>
        /// <param name="yLatitude">Latitude of center of the screen (degrees).</param>
        /// <param name="widthKilometers">Width of displayed extents in kilometres.</param>
        /// <remarks>Projection for the must be specified in order for this method to work.</remarks>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool SetGeographicExtents2(double xLongitude, double yLatitude, double widthKilometers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets known extents.
        /// </summary>
        /// <param name="extents">Known extents to retrieve.</param>
        /// <returns>Extents object.</returns>
        /// \new491 Added in version 4.9.1
        public Extents GetKnownExtents(tkKnownExtents extents)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets geographic extents of the map in decimal degrees.
        /// </summary>
        /// <remarks>For operation to succeed, projection must be set for the map (see AxMap.GeoProjection property). 
        /// Otherwise null will be returned.</remarks>
        /// \new490 Added in version 4.9.0
        public Extents GeographicExtents
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets geographic extents in decimal degrees for the map.
        /// </summary>
        /// <param name="pVal">Geographic extents in decimal degrees.</param>
        /// <returns>True on success.</returns>
        /// <remarks>For operation to succeed, projection must be set for the map (see AxMap.GeoProjection property)</remarks>
        /// \new490 Added in version 4.9.0
        public virtual bool SetGeographicExtents(Extents pVal)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets latitude of the center of screen (in decimal degrees). 
        /// </summary>
        /// <remarks>Map projection must be set in order for this property to work.</remarks>
        /// \new491 Added in version 4.9.1
        public float Latitude { get; set; }

        /// <summary>
        /// Gets or sets longitude of the center of screen (in decimal degrees). 
        /// </summary>
        /// <remarks>Map projection must be set in order for this property to work.</remarks>
        /// \new491 Added in version 4.9.1
        public float Longitude { get; set; }

        /// <summary>
        /// Gets or sets the current zoom level for the map. It corresponds to the zoom level of current tile provider.
        /// </summary>
        /// <remarks>Map projection must be set in order for this property to work.</remarks>
        /// \new491 Added in version 4.9.1
        public int CurrentZoom { get; set; }

        /// <summary>
        /// Gets or sets known extents for the map.
        /// </summary>
        /// <remarks>Map projection must be set in order for this property to work.</remarks>
        /// \new491 Added in version 4.9.1
        public tkKnownExtents KnownExtents { get; set; }

        /// <summary>
        /// Gets or sets the current map scale.
        /// </summary>
        /// <remarks>The scale depends on the AxMap.MapUnits property. Number of pixels per logical inch and the size of window are used to
        /// determine the size of the displaying device. The calculations represent the closest approximation as there is no way
        /// to determine the physical size of displaying device. The operation of setting the new scale preserve the map coordinates 
        /// of the center point on the screen.</remarks>
        /// \new48 Added in version 4.8
        public double CurrentScale
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the number of extents to cache in the extents history
        /// </summary>
        public int ExtentHistory
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the percentage of the view used to pad the extents of a layer when zooming to a layer or maximum extents.
        /// </summary>
        /// <remarks>
        /// Padding makes it so that there is a small border around the layer when you zoom to it.</remarks>
        public double ExtentPad
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the extents of the map using an Extents object. 
        /// </summary>
        /// <remarks>If the given extents do not fit the aspect ratio of the map, the map will fit the given extents as well as possible.</remarks>
        public object Extents
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the extents of the map displayed by the control.
        /// </summary>
        public MapWinGIS.Extents MaxExtents
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Deprecated. Updates the extents of the layer before the drawing.
        /// </summary>
        /// <param name="LayerHandle">The handle of the layer.</param>
        /// <returns>True on success and false in case of invalid layer handle.</returns>
        /// \deprecated v.4.8. The call is incorporated into drawing routine.
        public bool AdjustLayerExtents(int LayerHandle)
        {
            throw new NotImplementedException();
        }

        /// @}
        #endregion

        #region Projection and coordinates
        /// \addtogroup map_coordinates Map projection and coordinates
        /// Here is list of properties and methods which are related to coordinate system, projection of map and units conversion.
        /// This module is a part of the documentation of AxMap class.
        /// \dot
        /// digraph map_projection {
        /// splines = true;
        /// node [shape= "polygon", fontname=Helvetica, fontsize=9, style = filled, color = palegreen, height = 0.3, width = 1.2];
        /// lb [ label="AxMap" URL="\ref AxMap"];
        /// node [shape = "ellipse", color = khaki, width = 0.2, height = 0.2, style = filled]
        /// gr  [label="Max projection and coordianates" URL="\ref map_coordinates"];
        /// edge [ arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060" ]
        /// lb -> gr;
        /// }
        /// \enddot
        /// <a href = "diagrams.html">Graph description</a>\n\n
        /// \anchor a_projection
        /// \section proj1 A. Setting projection for the map.
        ///
        /// No matter what type of GIS application you are going to write, the decision about map coordinate system and projection is one of the first to be made. 
        /// MapWinGIS provides the following options.
        /// 
        /// \dot
        /// digraph projection_options {
        /// splines = true;
        /// ranksep = 0.15;
        /// nodesep = 0.5;
        /// node  [shape = oval, peripheries = 1, fontname=Helvetica, fontsize=9, fillcolor = gray, color = "gray", style = filled, height = 0.3, width = 0.8];
        /// render [ label="Choosing map projection"];
        /// 
        /// node  [shape = "note", width = 0.3, height = 0.3, peripheries = 1 fillcolor = "khaki" ]
        /// s1    [label=" Set projection manullay\l"];
        /// s2    [label=" Grab projection from data\l"];
        /// s3    [label=" Don't use projection at all\l"];
        /// 
        /// edge  [dir = none, arrowhead="open", style = solid, arrowsize = 0.6, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#808080" minlen=2 ]
        /// render -> s1;
        /// render -> s2;
        /// render -> s3;
        /// }
        /// \enddot
        /// Let's consider each of the approaches.
        ///
        /// <b>1. Settings projection manually.</b> \n\n
        /// It can be done using one of the following approaches:\n\n
        /// a) AxMap.Projection property - provides only most common projections (Spherical Mercator, WGS84) but available in Properties Window of Form designer.
        /// \code
        /// axMap1.Projection = tkMapProjection.PROJECTION_WGS84;
        /// \endcode
        /// b) For all other projections - GeoProjection class and AxMap.GeoProjection property:
        /// \code
        /// var gp = new GeoProjection();
        ///
        /// // one of the following methods can be used; see more in GeoProjection class
        /// // - use projections provided by MapWinGIS enumerations:
        /// gp.SetWgs84Projection(tkWgs84Projection.Wgs84_UTM_zone_22N);    
        /// gp.SetWellKnownGeogCS(tkCoordinateSystem.csNAD83);
        ///
        /// // - EPSG code of coordinate system; in this example Pulkovo 1942(83) / 3-degree Gauss-Kruger zone 5; see wwww.spatialreference.org for EPSG codes
        /// gp.ImportFromEPSG(2399);                                        
        ///
        /// // - importing from proj4 or WKT string; in this example proj4 string for Amersfoort / RD New projection for Netherlands
        /// gp.ImportFromAutoDetect("+proj=sterea +lat_0=52.15616055555555 +lon_0=5.38763888888889 +k=0.9999079 +x_0=155000 +y_0=463000 +ellps=bessel +units=m +no_defs ");
        ///
        /// // applying projection
        /// axMap1.GeoProjection = gp;
        /// \endcode
        ///
        /// <b>2. Grabbing coordinate system and projection from data.</b>
        /// \code
        /// axMap1.GrabProjectionFromData = true;   // default value
        /// axMap1.AddLayerFromFilename(@"d:\some_shapefile.shp", tkFileOpenStrategy.fosVectorLayer, true);
        /// \endcode
        /// GeoProjection will be taken from the first layer added to the map which has metadata about projection. AxMap.GeoProjection property will be updated from this metadata.
        /// When last layer is removed from map AxMap.GeoProjection property will be cleared (set to empty projection).
        /// 
        /// <b>3. Don't specify coordinate system at all.\n</b>
        /// - AxMap.Projection property is equal to PROJECTION_NONE (the default value);
        /// - map units should be set manually via AxMap.MapUnits;
        /// - calculation of distance and area will use Euclidean geometry with no account to the shape of Earth;
        /// - it won't be possible to display tiles from TMS servers.
        /// 
        /// To setup map to work without geoprojection use the code: 
        /// \code
        /// axMap1.Projection = tkMapProjection.PROJECTION_NONE;
        /// axMap1.GrabProjectionFromData = false;
        /// axMap1.MapUnits = tkUnitsOfMeasure.umMeters;	// or another, depending on the data you display
        /// \endcode
        /// 
        /// \section proj2 B. Interaction with already set projection
        /// 
        /// To check that map actually has a projection:
        /// \code
        /// Debug.WriteLine("Map has projection:" + (axMap1.Projection != tkMapProjection.PROJECTION_NONE));
        /// // or with mode details
        /// Debug.WriteLine("Projection of the map: " + (axMap1.GeoProjection.IsEmpty() ? "None" : axMap1.GeoProjection.ExportToWKT());
        /// \endcode
        ///
        /// Another way to check whether map has geoprojection is to see how coordinates are displayed when AxMap.ShowCoordinates is set to cdmAuto. 
        /// In case decimal degrees are displayed (Lat/Lng) - map has geoprojection, if x/y pair is shown - no geoprojection was set.
        ///
        /// All of these methods will result in updating AxMap.GeoProjection property. GeoProjection object assigned to map is protected from changes, 
        /// i.e. GeoProjection.IsFrozen = true. To change already assigned projection, a new instance of GeoProjection object must be created:
        /// \code
        /// // this one will fail, because projection is frozen
        /// if (!axMap1.GeoProjection.ImportFromEPSG(2399))
        /// {
        ///	   Debug.WriteLine("Projection wasn't set: " + axMap1.GeoProjection.get_ErrorMsg(axMap1.GeoProjection.LastErrorCode));
        /// }
        /// // this one will succeed as a new GeoProjection instance is created by Clone method:
        /// var gp = axMap1.GeoProjection.Clone();
        /// if (gp.ImportFromEPSG(2399))
        /// {
        ///	   axMap1.GeoProjection = gp;
        /// }
        /// \endcode
        ///
        /// Regardless of the method for settings projection MapWinGIS will update AxMap.MapUnits. IF coordinate system is geographic one umDecimalDegrees 
        /// will be set, otherwise umMeters. This will ensure that scalebar and measuring will work correctly.
        /// 
        /// \section proj3 C. Choosing projection
        /// 
        /// When making decision about coordinate system and projection consider:\n\n
        /// 1. Whether it's important to display tiles from online services. Most TMS servers use Shperical Mercator projection (EPSG:3857), 
        /// therefore to avoid distortions of tiles map projection should be set to GoogleMercator as well:
        /// \code
        /// axMap1.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
        /// \endcode
        /// \note See more details on the issue in description of Tiles class.\n\n
        /// 
        /// 2. What data you plan to display and what projection it's using. It's possible to do a reprojection with:
        /// - Utils.ReprojectShapefile for shapefiles;
        /// - Utils.GDALWarp for images and grids.
        /// 
        /// But it should be considered whether it is worth the effort.
        /// 
        /// Starting from version 4.9.2. built-in projection mismatch testing is implemented + optional 
        /// transformation for shapefiles. See AxMap.ProjectionMismatchBehavior.
        /// 
        /// @{

        /// <summary>
        /// Gets measuring object associated with map.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public Measuring Measuring
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the units of measure for the map.
        /// </summary>
        /// <remarks>This units must be the same as the units of the datasources being displayed. 
        /// This method affects the calculation of map scale (see AxMap.CurrentScale).</remarks>
        /// \new48 Added in version 4.8
        public MapWinGIS.tkUnitsOfMeasure MapUnits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Converts pixel coordinates to projected map coordinates
        /// </summary>
        /// <param name="pixelX">The x pixel coordinate to be converted into the projected x map coordinate.</param>
        /// <param name="pixelY">The y pixel coordinate to be converted into the projected y map coordinate</param>
        /// <param name="projX">The projected x map coordinate is returned through this reference parameter.</param>
        /// <param name="projY">The projected y map coordinate is returned through this reference parameter.</param>
        public void PixelToProj(double pixelX, double pixelY, ref double projX, ref double projY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of screen pixels per the decimal degree of the data.
        /// </summary>
        /// <remarks>The set part of this property isn't supported. The correctness of results depends on AxMap.MapUnits property.</remarks>
        /// \new48 Added in version 4.8
        public double PixelsPerDegree
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Converts projected map coordinates into screen pixel units
        /// </summary>
        /// <param name="projX">The projected x map coordinate to be converted into the x pixel coordinate.</param>
        /// <param name="projY">The projected y map coordinate to be converted into the y pixel coordinate.</param>
        /// <param name="pixelX">The pixel x coordinate is returned through this reference parameter</param>
        /// <param name="pixelY">The pixel y coordinate is returned through this reference parameter.</param>
        public void ProjToPixel(double projX, double projY, ref double pixelX, ref double pixelY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Tests the identity of 2 projections.
        /// </summary>
        /// <param name="proj4_a">The first projection string.</param>
        /// <param name="proj4_b">The second projection string.</param>
        /// <returns></returns>
        /// \see GeoProjection.get_IsSame, GeoProjection.get_IsSameExt.
        public bool IsSameProjection(string proj4_a, string proj4_b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets a value indicating whether coordinates of the current mouse position will be displayed on map.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public tkCoordinatesDisplay ShowCoordinates { get; set; }

        /// <summary>
        /// Gets or sets a value which indicate whether scalebar will be displayed on the map.
        /// </summary>
        /// \new490 Added in version 4.9.0
        public bool ScalebarVisible
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets units to be displayed for map scalebar.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public tkScalebarUnits ScalebarUnits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether projection for will be taken from the first datasource added to it.
        /// </summary>
        /// <remarks>If set to true projection will be taken from the first layer added to the map which has a projection. 
        /// On removing the last layer projection of the map will be cleared (set to an empty one).</remarks>
        /// \new491 Added in version 4.9.1
        public bool GrabProjectionFromData { get; set; }

        /// <summary>
        /// Sets projection of the map. It providers 2 most commonly used coordinate system/projections to be easily set from Form Designer. 
        /// To set other projections initialize GeoProjection object manually and use AxMap.GeoProjection property.
        /// </summary>
        /// <remarks></remarks>
        /// \new491 Added in version 4.9.1
        public tkMapProjection Projection { get; set; }

        /// <summary>
        /// Gets or sets projection for map. 
        /// </summary>
        /// <remarks>Projection layered set to map must not be changed, but rather a new instance 
        /// of GeoProjection should be created (GeoProjection.Clone) and set to the property.
        /// This property must be set in order for certain functionality to work (tiles, for example).</remarks>
        /// \new490 Added in version 4.9.0
        public GeoProjection GeoProjection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Converts projected map coordinates to decimal degrees (map projection must be specified for this method to work). 
        /// </summary>
        /// <param name="projX">Projected X map coordinate.</param>
        /// <param name="projY">Projected Y map coordinate.</param>
        /// <param name="degreesLngX">Converted longitude in decimal degrees</param>
        /// <param name="degreesLatY">Converted latitude in decimal degrees</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool ProjToDegrees(double projX, double projY, ref double degreesLngX, ref double degreesLatY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts coordinates in decimal degrees to pixel coordinates (map projection must be specified for this method to work). 
        /// </summary>
        /// <param name="pixelX">X screen coordinate.</param>
        /// <param name="pixelY">Y screen coordinate.</param>
        /// <param name="degreesLngX">Converted longitude in decimal degrees</param>
        /// <param name="degreesLatY">Converted latitude in decimal degrees</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool PixelToDegrees(double pixelX, double pixelY, ref double degreesLngX, ref double degreesLatY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts coordinates in decimal degrees to projected map coordinates (map projection must be specified for this method to work). 
        /// </summary>
        /// <param name="degreesLngX">Longitude in decimal degrees.</param>
        /// <param name="degreesLatY">Latitude in decimal degrees.</param>
        /// <param name="projX">Resulting projected X map coordinate.</param>
        /// <param name="projY">Resulting Projected Y map coordinate.</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool DegreesToProj(double degreesLngX, double degreesLatY, ref double projX, ref double projY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts pixel coordinates to decimal degrees (map projection must be specified for this method to work). 
        /// </summary>
        /// <param name="degreesLngX">Longitude in decimal degrees.</param>
        /// <param name="degreesLatY">Latitude in decimal degrees.</param>
        /// <param name="pixelX">Converted X screen coordinate.</param>
        /// <param name="pixelY">Converted Y screen coordinate.</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool DegreesToPixel(double degreesLngX, double degreesLatY, ref double pixelX, ref double pixelY)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets behavior to be used when projection of a layer being added to the map
        /// doesn't match the projection of the map.
        /// </summary>
        /// <remarks>The default value pmbIgnore. Automatic transformation for shapefile is avaiable as an option.</remarks>
        /// \new492 Added in version 4.9.2
        public tkMismatchBehavior ProjectionMismatchBehavior { get; set; }

        /// @}
        #endregion

        /// @}
    }
#if nsp
}
#endif
