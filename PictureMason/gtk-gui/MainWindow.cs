
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action dialogQuestionAction;

	private global::Gtk.Action zoomInAction1;

	private global::Gtk.Action zoomInAction;

	private global::Gtk.Action zoomOutAction;

	private global::Gtk.Action zoomOutAction1;

	private global::Gtk.Action AboutAction;

	private global::Gtk.Action MainmenuHelpAction;

	private global::Gtk.Action helpAction;

	private global::Gtk.Action quitAction;

	private global::Gtk.Action protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction;

	private global::Gtk.Action protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction1;

	private global::Gtk.Action MenuoptionAbout;

	private global::Gtk.VBox OuterVBox;

	private global::Gtk.MenuBar ProgramMenubar;

	private global::Gtk.VPaned TabsheetMsgboxDividor;

	private global::Gtk.Notebook MainTabNotebook;

	private global::Gtk.HPaned WorkbenchHPaneD;

	private global::Gtk.VPaned WorkbenchLeftVPaneD;

	private global::Gtk.FileChooserWidget InputImageFileSelector;

	private global::Gtk.VBox InputImageVBox;

	private global::Gtk.Toolbar InputImageToolbar;

	private global::Gtk.ScrolledWindow InputimageWindow;

	private global::Gtk.Image InputImageDisplay;

	private global::Gtk.VPaned WorkbenchRightVPaneD;

	private global::Gtk.ComboBox TilesetSelector;

	private global::Gtk.VBox PreviewImageVBox;

	private global::Gtk.Toolbar PreviewImageToolbar;

	private global::Gtk.ScrolledWindow PreviewImageWindow;

	private global::Gtk.Image PreviewImageDisplay;

	private global::Gtk.Label WorkbenchTab;

	private global::Gtk.ScrolledWindow GtkScrolledWindow3;

	private global::Gtk.TextView TilesetTextContent;

	private global::Gtk.Label TilesetsTab;

	private global::Gtk.Label ExportTab;

	private global::Gtk.ScrolledWindow MessageBoxPane;

	private global::Gtk.TextView MessagesBox;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.dialogQuestionAction = new global::Gtk.Action("dialogQuestionAction", global::Mono.Unix.Catalog.GetString("Quit"), null, "gtk-dialog-question");
		this.dialogQuestionAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Quit");
		w1.Add(this.dialogQuestionAction, null);
		this.zoomInAction1 = new global::Gtk.Action("zoomInAction1", null, null, "gtk-zoom-in");
		w1.Add(this.zoomInAction1, null);
		this.zoomInAction = new global::Gtk.Action("zoomInAction", null, null, "gtk-zoom-in");
		w1.Add(this.zoomInAction, null);
		this.zoomOutAction = new global::Gtk.Action("zoomOutAction", null, null, "gtk-zoom-out");
		w1.Add(this.zoomOutAction, null);
		this.zoomOutAction1 = new global::Gtk.Action("zoomOutAction1", null, null, "gtk-zoom-out");
		w1.Add(this.zoomOutAction1, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction, null);
		this.MainmenuHelpAction = new global::Gtk.Action("MainmenuHelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, "gtk-help");
		this.MainmenuHelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
		w1.Add(this.MainmenuHelpAction, null);
		this.helpAction = new global::Gtk.Action("helpAction", global::Mono.Unix.Catalog.GetString("About"), null, "gtk-help");
		this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.helpAction, null);
		this.quitAction = new global::Gtk.Action("quitAction", global::Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("_Quit");
		w1.Add(this.quitAction, null);
		this.protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction = new global::Gtk.Action("protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueA" +
				"ction", global::Mono.Unix.Catalog.GetString("protected void OnDeleteEvent(object sender, DeleteEventArgs a)\n\t{\n\t\tApplication.Q" +
					"uit();\n\t\ta.RetVal = true;\n\t}\n\n\n"), null, null);
		this.protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction.ShortLabel = global::Mono.Unix.Catalog.GetString("protected void OnDeleteEvent(object sender, DeleteEventArgs a)\n\t{\n\t\tApplication.Q" +
				"uit();\n\t\ta.RetVal = true;\n\t}\n\n\n");
		w1.Add(this.protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction, null);
		this.protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction1 = new global::Gtk.Action("protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueA" +
				"ction1", global::Mono.Unix.Catalog.GetString("protected void OnDeleteEvent(object sender, DeleteEventArgs a)\n\t{\n\t\tApplication.Q" +
					"uit();\n\t\ta.RetVal = true;\n\t}\n\n\n"), null, null);
		this.protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("protected void OnDeleteEvent(object sender, DeleteEventArgs a)\n\t{\n\t\tApplication.Q" +
				"uit();\n\t\ta.RetVal = true;\n\t}\n\n\n");
		w1.Add(this.protectedVoidOnDeleteEventObjectSenderDeleteEventArgsAApplicationQuitARetValTrueAction1, null);
		this.MenuoptionAbout = new global::Gtk.Action("MenuoptionAbout", global::Mono.Unix.Catalog.GetString("About"), null, "gtk-about");
		this.MenuoptionAbout.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.MenuoptionAbout, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.OuterVBox = new global::Gtk.VBox();
		this.OuterVBox.Name = "OuterVBox";
		this.OuterVBox.Spacing = 6;
		// Container child OuterVBox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='ProgramMenubar'><menu name='FileAction' action='FileAction'><menuitem name='quitAction' action='quitAction'/></menu><menu name='MainmenuHelpAction' action='MainmenuHelpAction'><menuitem name='MenuoptionAbout' action='MenuoptionAbout'/></menu></menubar></ui>");
		this.ProgramMenubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/ProgramMenubar")));
		this.ProgramMenubar.Name = "ProgramMenubar";
		this.OuterVBox.Add(this.ProgramMenubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.OuterVBox[this.ProgramMenubar]));
		w2.Position = 0;
		w2.Expand = false;
		// Container child OuterVBox.Gtk.Box+BoxChild
		this.TabsheetMsgboxDividor = new global::Gtk.VPaned();
		this.TabsheetMsgboxDividor.CanFocus = true;
		this.TabsheetMsgboxDividor.Name = "TabsheetMsgboxDividor";
		this.TabsheetMsgboxDividor.Position = 646;
		this.TabsheetMsgboxDividor.BorderWidth = ((uint)(4));
		// Container child TabsheetMsgboxDividor.Gtk.Paned+PanedChild
		this.MainTabNotebook = new global::Gtk.Notebook();
		this.MainTabNotebook.CanFocus = true;
		this.MainTabNotebook.Name = "MainTabNotebook";
		this.MainTabNotebook.CurrentPage = 0;
		// Container child MainTabNotebook.Gtk.Notebook+NotebookChild
		this.WorkbenchHPaneD = new global::Gtk.HPaned();
		this.WorkbenchHPaneD.CanFocus = true;
		this.WorkbenchHPaneD.Name = "WorkbenchHPaneD";
		this.WorkbenchHPaneD.Position = 502;
		// Container child WorkbenchHPaneD.Gtk.Paned+PanedChild
		this.WorkbenchLeftVPaneD = new global::Gtk.VPaned();
		this.WorkbenchLeftVPaneD.CanFocus = true;
		this.WorkbenchLeftVPaneD.Name = "WorkbenchLeftVPaneD";
		this.WorkbenchLeftVPaneD.Position = 274;
		// Container child WorkbenchLeftVPaneD.Gtk.Paned+PanedChild
		this.InputImageFileSelector = new global::Gtk.FileChooserWidget(((global::Gtk.FileChooserAction)(0)));
		this.InputImageFileSelector.Name = "InputImageFileSelector";
		this.WorkbenchLeftVPaneD.Add(this.InputImageFileSelector);
		global::Gtk.Paned.PanedChild w3 = ((global::Gtk.Paned.PanedChild)(this.WorkbenchLeftVPaneD[this.InputImageFileSelector]));
		w3.Resize = false;
		// Container child WorkbenchLeftVPaneD.Gtk.Paned+PanedChild
		this.InputImageVBox = new global::Gtk.VBox();
		this.InputImageVBox.Name = "InputImageVBox";
		this.InputImageVBox.Spacing = 6;
		// Container child InputImageVBox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><toolbar name=\'InputImageToolbar\'><toolitem name=\'zoomInAction\' action=\'zoomI" +
				"nAction\'/><toolitem name=\'zoomOutAction\' action=\'zoomOutAction\'/></toolbar></ui>" +
				"");
		this.InputImageToolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/InputImageToolbar")));
		this.InputImageToolbar.Name = "InputImageToolbar";
		this.InputImageToolbar.ShowArrow = false;
		this.InputImageVBox.Add(this.InputImageToolbar);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.InputImageVBox[this.InputImageToolbar]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child InputImageVBox.Gtk.Box+BoxChild
		this.InputimageWindow = new global::Gtk.ScrolledWindow();
		this.InputimageWindow.CanFocus = true;
		this.InputimageWindow.Name = "InputimageWindow";
		this.InputimageWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child InputimageWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w5 = new global::Gtk.Viewport();
		w5.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport2.Gtk.Container+ContainerChild
		this.InputImageDisplay = new global::Gtk.Image();
		this.InputImageDisplay.Name = "InputImageDisplay";
		w5.Add(this.InputImageDisplay);
		this.InputimageWindow.Add(w5);
		this.InputImageVBox.Add(this.InputimageWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.InputImageVBox[this.InputimageWindow]));
		w8.Position = 1;
		this.WorkbenchLeftVPaneD.Add(this.InputImageVBox);
		this.WorkbenchHPaneD.Add(this.WorkbenchLeftVPaneD);
		global::Gtk.Paned.PanedChild w10 = ((global::Gtk.Paned.PanedChild)(this.WorkbenchHPaneD[this.WorkbenchLeftVPaneD]));
		w10.Resize = false;
		// Container child WorkbenchHPaneD.Gtk.Paned+PanedChild
		this.WorkbenchRightVPaneD = new global::Gtk.VPaned();
		this.WorkbenchRightVPaneD.CanFocus = true;
		this.WorkbenchRightVPaneD.Name = "WorkbenchRightVPaneD";
		this.WorkbenchRightVPaneD.Position = 49;
		// Container child WorkbenchRightVPaneD.Gtk.Paned+PanedChild
		this.TilesetSelector = global::Gtk.ComboBox.NewText();
		this.TilesetSelector.Name = "TilesetSelector";
		this.WorkbenchRightVPaneD.Add(this.TilesetSelector);
		global::Gtk.Paned.PanedChild w11 = ((global::Gtk.Paned.PanedChild)(this.WorkbenchRightVPaneD[this.TilesetSelector]));
		w11.Resize = false;
		// Container child WorkbenchRightVPaneD.Gtk.Paned+PanedChild
		this.PreviewImageVBox = new global::Gtk.VBox();
		this.PreviewImageVBox.Name = "PreviewImageVBox";
		this.PreviewImageVBox.Spacing = 6;
		// Container child PreviewImageVBox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><toolbar name=\'PreviewImageToolbar\'><toolitem name=\'zoomInAction1\' action=\'zo" +
				"omInAction1\'/><toolitem name=\'zoomOutAction1\' action=\'zoomOutAction1\'/></toolbar" +
				"></ui>");
		this.PreviewImageToolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/PreviewImageToolbar")));
		this.PreviewImageToolbar.Name = "PreviewImageToolbar";
		this.PreviewImageToolbar.ShowArrow = false;
		this.PreviewImageVBox.Add(this.PreviewImageToolbar);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.PreviewImageVBox[this.PreviewImageToolbar]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child PreviewImageVBox.Gtk.Box+BoxChild
		this.PreviewImageWindow = new global::Gtk.ScrolledWindow();
		this.PreviewImageWindow.CanFocus = true;
		this.PreviewImageWindow.Name = "PreviewImageWindow";
		this.PreviewImageWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child PreviewImageWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w13 = new global::Gtk.Viewport();
		w13.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.PreviewImageDisplay = new global::Gtk.Image();
		this.PreviewImageDisplay.Name = "PreviewImageDisplay";
		w13.Add(this.PreviewImageDisplay);
		this.PreviewImageWindow.Add(w13);
		this.PreviewImageVBox.Add(this.PreviewImageWindow);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.PreviewImageVBox[this.PreviewImageWindow]));
		w16.Position = 1;
		this.WorkbenchRightVPaneD.Add(this.PreviewImageVBox);
		this.WorkbenchHPaneD.Add(this.WorkbenchRightVPaneD);
		this.MainTabNotebook.Add(this.WorkbenchHPaneD);
		// Notebook tab
		this.WorkbenchTab = new global::Gtk.Label();
		this.WorkbenchTab.Name = "WorkbenchTab";
		this.WorkbenchTab.LabelProp = global::Mono.Unix.Catalog.GetString("Workbench");
		this.MainTabNotebook.SetTabLabel(this.WorkbenchHPaneD, this.WorkbenchTab);
		this.WorkbenchTab.ShowAll();
		// Container child MainTabNotebook.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
		this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
		this.TilesetTextContent = new global::Gtk.TextView();
		this.TilesetTextContent.CanFocus = true;
		this.TilesetTextContent.Name = "TilesetTextContent";
		this.GtkScrolledWindow3.Add(this.TilesetTextContent);
		this.MainTabNotebook.Add(this.GtkScrolledWindow3);
		global::Gtk.Notebook.NotebookChild w21 = ((global::Gtk.Notebook.NotebookChild)(this.MainTabNotebook[this.GtkScrolledWindow3]));
		w21.Position = 1;
		// Notebook tab
		this.TilesetsTab = new global::Gtk.Label();
		this.TilesetsTab.Name = "TilesetsTab";
		this.TilesetsTab.LabelProp = global::Mono.Unix.Catalog.GetString("Tilesets");
		this.MainTabNotebook.SetTabLabel(this.GtkScrolledWindow3, this.TilesetsTab);
		this.TilesetsTab.ShowAll();
		// Notebook tab
		global::Gtk.Label w22 = new global::Gtk.Label();
		w22.Visible = true;
		this.MainTabNotebook.Add(w22);
		this.ExportTab = new global::Gtk.Label();
		this.ExportTab.Name = "ExportTab";
		this.ExportTab.LabelProp = global::Mono.Unix.Catalog.GetString("Export");
		this.MainTabNotebook.SetTabLabel(w22, this.ExportTab);
		this.ExportTab.ShowAll();
		this.TabsheetMsgboxDividor.Add(this.MainTabNotebook);
		global::Gtk.Paned.PanedChild w23 = ((global::Gtk.Paned.PanedChild)(this.TabsheetMsgboxDividor[this.MainTabNotebook]));
		w23.Resize = false;
		// Container child TabsheetMsgboxDividor.Gtk.Paned+PanedChild
		this.MessageBoxPane = new global::Gtk.ScrolledWindow();
		this.MessageBoxPane.Name = "MessageBoxPane";
		this.MessageBoxPane.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child MessageBoxPane.Gtk.Container+ContainerChild
		this.MessagesBox = new global::Gtk.TextView();
		this.MessagesBox.HeightRequest = 32;
		this.MessagesBox.Name = "MessagesBox";
		this.MessageBoxPane.Add(this.MessagesBox);
		this.TabsheetMsgboxDividor.Add(this.MessageBoxPane);
		this.OuterVBox.Add(this.TabsheetMsgboxDividor);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.OuterVBox[this.TabsheetMsgboxDividor]));
		w26.PackType = ((global::Gtk.PackType)(1));
		w26.Position = 1;
		this.Add(this.OuterVBox);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 981;
		this.DefaultHeight = 891;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.zoomInAction.Activated += new global::System.EventHandler(this.OnInputImageZoomin);
		this.helpAction.Activated += new global::System.EventHandler(this.ShowAbout);
		this.quitAction.Activated += new global::System.EventHandler(this.QuitRequested);
		this.MenuoptionAbout.Activated += new global::System.EventHandler(this.ShowAbout);
		this.InputImageFileSelector.SelectionChanged += new global::System.EventHandler(this.OnInputImageFileSelectorSelectionChanged);
		this.TilesetSelector.Changed += new global::System.EventHandler(this.OnTilesetSelectorChanged);
	}
}
