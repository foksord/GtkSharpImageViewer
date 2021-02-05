using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnOpen (object sender, EventArgs e)
	{
		FileChooserDialog fileChooser = new FileChooserDialog ("Choose an Image to View", this, FileChooserAction.Open, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);
        if (fileChooser.Run () == (int)ResponseType.Accept) {

			if(fileChooser.Filename.ToLower().EndsWith(".png", StringComparison.CurrentCulture) || fileChooser.Filename.ToLower().EndsWith(".gif", StringComparison.CurrentCulture) || fileChooser.Filename.ToLower().EndsWith(".jpg", StringComparison.CurrentCulture))
				{
					if (displayImage != null && displayImage.Pixbuf != null)
						displayImage.Pixbuf.Dispose ();
                    
                    displayImage.SetSizeRequest(330, 330);
					displayImage.Pixbuf = new Gdk.Pixbuf ( fileChooser.Filename);
				}
		}

        fileChooser.Destroy ();
				
	}

	protected void OnAbout (object sender, EventArgs e)
	{
		var about = new AboutDialog ();
		about.ProgramName = "Foksord's Image Viewer";
		about.Version = "1.0.0";
		about.Run ();

		about.Destroy ();
		               
	}
	

	protected void OnExit (object sender, EventArgs e)
	{
		Application.Quit ();
	}
	
}
