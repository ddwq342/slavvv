using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PUK_Anjamakan;

public class RJDropdownMenu : ContextMenuStrip
{
	private bool isMainMenu;

	private int menuItemHeight = 25;

	private Color menuItemTextColor = Color.Empty;

	private Color primaryColor = Color.Empty;

	private Bitmap menuItemHeaderSize;

	[Browsable(false)]
	public bool IsMainMenu
	{
		get
		{
			return isMainMenu;
		}
		set
		{
			isMainMenu = value;
		}
	}

	[Browsable(false)]
	public int MenuItemHeight
	{
		get
		{
			return menuItemHeight;
		}
		set
		{
			menuItemHeight = value;
		}
	}

	[Browsable(false)]
	public Color MenuItemTextColor
	{
		get
		{
			return menuItemTextColor;
		}
		set
		{
			menuItemTextColor = value;
		}
	}

	[Browsable(false)]
	public Color PrimaryColor
	{
		get
		{
			return primaryColor;
		}
		set
		{
			primaryColor = value;
		}
	}

	public RJDropdownMenu(IContainer container)
		: base(container)
	{
	}

	private void LoadMenuItemHeight()
	{
		if (isMainMenu)
		{
			menuItemHeaderSize = new Bitmap(25, 45);
		}
		else
		{
			menuItemHeaderSize = new Bitmap(20, menuItemHeight);
		}
		foreach (ToolStripMenuItem menuItemL1 in Items)
		{
			menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
			if (menuItemL1.Image == null)
			{
				menuItemL1.Image = menuItemHeaderSize;
			}
			foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
			{
				menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
				if (menuItemL2.Image == null)
				{
					menuItemL2.Image = menuItemHeaderSize;
				}
				foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
				{
					menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
					if (menuItemL3.Image == null)
					{
						menuItemL3.Image = menuItemHeaderSize;
					}
					foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
					{
						menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
						if (menuItemL4.Image == null)
						{
							menuItemL4.Image = menuItemHeaderSize;
						}
					}
				}
			}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		if (!base.DesignMode)
		{
			base.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
			LoadMenuItemHeight();
		}
	}
}
