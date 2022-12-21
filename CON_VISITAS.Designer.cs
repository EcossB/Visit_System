
namespace Final_project
{
    partial class CON_VISITAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CON_VISITAS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.c_edificio = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tabla = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.button_search = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // c_edificio
            // 
            this.c_edificio.BackColor = System.Drawing.Color.Transparent;
            this.c_edificio.BackgroundColor = System.Drawing.Color.White;
            this.c_edificio.BorderColor = System.Drawing.Color.Silver;
            this.c_edificio.BorderRadius = 1;
            this.c_edificio.Color = System.Drawing.Color.Silver;
            this.c_edificio.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.c_edificio.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c_edificio.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.c_edificio.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c_edificio.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.c_edificio.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.c_edificio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.c_edificio.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.c_edificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_edificio.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.c_edificio.FillDropDown = true;
            this.c_edificio.FillIndicator = false;
            this.c_edificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_edificio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c_edificio.ForeColor = System.Drawing.Color.Black;
            this.c_edificio.FormattingEnabled = true;
            this.c_edificio.Icon = null;
            this.c_edificio.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.c_edificio.IndicatorColor = System.Drawing.Color.DarkGray;
            this.c_edificio.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.c_edificio.IndicatorThickness = 2;
            this.c_edificio.IsDropdownOpened = false;
            this.c_edificio.ItemBackColor = System.Drawing.Color.White;
            this.c_edificio.ItemBorderColor = System.Drawing.Color.White;
            this.c_edificio.ItemForeColor = System.Drawing.Color.Black;
            this.c_edificio.ItemHeight = 26;
            this.c_edificio.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.c_edificio.ItemHighLightForeColor = System.Drawing.Color.White;
            this.c_edificio.ItemTopMargin = 3;
            this.c_edificio.Location = new System.Drawing.Point(204, 73);
            this.c_edificio.Name = "c_edificio";
            this.c_edificio.Size = new System.Drawing.Size(260, 32);
            this.c_edificio.TabIndex = 0;
            this.c_edificio.Text = "Edificio";
            this.c_edificio.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.c_edificio.TextLeftMargin = 5;
            this.c_edificio.SelectedIndexChanged += new System.EventHandler(this.combo_edificio_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(123, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(647, 42);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Visitas por los diferentes edificios";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tabla
            // 
            this.tabla.AllowCustomTheming = false;
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.ColumnHeadersHeight = 40;
            this.tabla.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tabla.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tabla.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabla.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabla.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tabla.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tabla.CurrentTheme.Name = null;
            this.tabla.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tabla.HeaderBgColor = System.Drawing.Color.Empty;
            this.tabla.HeaderForeColor = System.Drawing.Color.White;
            this.tabla.Location = new System.Drawing.Point(12, 121);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowTemplate.Height = 40;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(898, 463);
            this.tabla.TabIndex = 2;
            this.tabla.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // button_search
            // 
            this.button_search.AllowAnimations = true;
            this.button_search.AllowMouseEffects = true;
            this.button_search.AllowToggling = false;
            this.button_search.AnimationSpeed = 200;
            this.button_search.AutoGenerateColors = false;
            this.button_search.AutoRoundBorders = false;
            this.button_search.AutoSizeLeftIcon = true;
            this.button_search.AutoSizeRightIcon = true;
            this.button_search.BackColor = System.Drawing.Color.Transparent;
            this.button_search.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_search.ButtonText = "Search";
            this.button_search.ButtonTextMarginLeft = 0;
            this.button_search.ColorContrastOnClick = 45;
            this.button_search.ColorContrastOnHover = 45;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_search.CustomizableEdges = borderEdges1;
            this.button_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_search.DisabledFillColor = System.Drawing.Color.Empty;
            this.button_search.DisabledForecolor = System.Drawing.Color.Empty;
            this.button_search.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_search.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.IconLeft = null;
            this.button_search.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_search.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_search.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_search.IconMarginLeft = 11;
            this.button_search.IconPadding = 10;
            this.button_search.IconRight = null;
            this.button_search.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_search.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_search.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_search.IconSize = 25;
            this.button_search.IdleBorderColor = System.Drawing.Color.Empty;
            this.button_search.IdleBorderRadius = 0;
            this.button_search.IdleBorderThickness = 0;
            this.button_search.IdleFillColor = System.Drawing.Color.Empty;
            this.button_search.IdleIconLeftImage = null;
            this.button_search.IdleIconRightImage = null;
            this.button_search.IndicateFocus = false;
            this.button_search.Location = new System.Drawing.Point(482, 73);
            this.button_search.Name = "button_search";
            this.button_search.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_search.OnDisabledState.BorderRadius = 1;
            this.button_search.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_search.OnDisabledState.BorderThickness = 1;
            this.button_search.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_search.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_search.OnDisabledState.IconLeftImage = null;
            this.button_search.OnDisabledState.IconRightImage = null;
            this.button_search.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button_search.onHoverState.BorderRadius = 1;
            this.button_search.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_search.onHoverState.BorderThickness = 1;
            this.button_search.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button_search.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_search.onHoverState.IconLeftImage = null;
            this.button_search.onHoverState.IconRightImage = null;
            this.button_search.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.button_search.OnIdleState.BorderRadius = 1;
            this.button_search.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_search.OnIdleState.BorderThickness = 1;
            this.button_search.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.button_search.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_search.OnIdleState.IconLeftImage = null;
            this.button_search.OnIdleState.IconRightImage = null;
            this.button_search.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_search.OnPressedState.BorderRadius = 1;
            this.button_search.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_search.OnPressedState.BorderThickness = 1;
            this.button_search.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_search.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_search.OnPressedState.IconLeftImage = null;
            this.button_search.OnPressedState.IconRightImage = null;
            this.button_search.Size = new System.Drawing.Size(221, 32);
            this.button_search.TabIndex = 32;
            this.button_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_search.TextMarginLeft = 0;
            this.button_search.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_search.UseDefaultRadiusAndThickness = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // CON_VISITAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 596);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.c_edificio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CON_VISITAS";
            this.Text = "CON_VISITAS";
            this.Load += new System.EventHandler(this.CON_VISITAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown c_edificio;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView tabla;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_search;
    }
}