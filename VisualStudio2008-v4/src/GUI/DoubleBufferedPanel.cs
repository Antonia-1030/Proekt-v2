﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Потребителски контрол, в който ще се визуализира модела.
	/// Използва се за визуализация с двойно буфериране.
	/// </summary>
	public partial class DoubleBufferedPanel : UserControl
	{
		public DoubleBufferedPanel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        public object Image { get; internal set; }

        /*internal void Save(FileStream filestr, ImageFormat png)
        {
            throw new NotImplementedException();
        }*/
    }
}
