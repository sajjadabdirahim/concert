<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class artistDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(artistDashboard))
        venueBookingBtn = New Button()
        analysisBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' venueBookingBtn
        ' 
        venueBookingBtn.BackColor = Color.DeepSkyBlue
        venueBookingBtn.FlatAppearance.BorderSize = 0
        venueBookingBtn.FlatStyle = FlatStyle.Flat
        venueBookingBtn.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        venueBookingBtn.Location = New Point(170, 409)
        venueBookingBtn.Margin = New Padding(3, 2, 3, 2)
        venueBookingBtn.Name = "venueBookingBtn"
        venueBookingBtn.Size = New Size(107, 47)
        venueBookingBtn.TabIndex = 0
        venueBookingBtn.Text = "Book Venue"
        venueBookingBtn.UseVisualStyleBackColor = False
        ' 
        ' analysisBtn
        ' 
        analysisBtn.BackColor = Color.DeepSkyBlue
        analysisBtn.FlatAppearance.BorderSize = 0
        analysisBtn.FlatStyle = FlatStyle.Flat
        analysisBtn.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        analysisBtn.Location = New Point(801, 409)
        analysisBtn.Margin = New Padding(3, 2, 3, 2)
        analysisBtn.Name = "analysisBtn"
        analysisBtn.Size = New Size(107, 47)
        analysisBtn.TabIndex = 1
        analysisBtn.Text = "Analysis"
        analysisBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGray
        Label1.Location = New Point(55, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 30)
        Label1.TabIndex = 2
        Label1.Text = "WELCOME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(55, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(750, 18)
        Label2.TabIndex = 3
        Label2.Text = "Here's your artist dashboard, giving you full control over your concert bookings and profit analysis."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Black", 15.75F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(55, 354)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 30)
        Label3.TabIndex = 4
        Label3.Text = "BOOK VENUES"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(55, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(516, 19)
        Label4.TabIndex = 5
        Label4.Text = "Click below to explore available venues for your next performance:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Black", 15.75F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(649, 354)
        Label5.Name = "Label5"
        Label5.Size = New Size(221, 30)
        Label5.TabIndex = 6
        Label5.Text = "PROFIT ANALYSIS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(641, 380)
        Label6.Name = "Label6"
        Label6.Size = New Size(476, 19)
        Label6.TabIndex = 7
        Label6.Text = "Keep track of your earnings and analyze your concert profits:"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.ForeColor = Color.OrangeRed
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1201, 81)
        FlowLayoutPanel1.TabIndex = 40
        ' 
        ' PictureBox1
        ' 
        PictureBox1.AccessibleRole = AccessibleRole.None
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label7)
        FlowLayoutPanel2.Controls.Add(Label8)
        FlowLayoutPanel2.Location = New Point(110, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(775, 78)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Enabled = False
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkGray
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(674, 50)
        Label7.TabIndex = 13
        Label7.Text = "CONCERT MANAGEMENT SYSTEM"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Enabled = False
        Label8.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkGray
        Label8.Location = New Point(3, 50)
        Label8.Name = "Label8"
        Label8.Size = New Size(254, 32)
        Label8.TabIndex = 13
        Label8.Text = "By Fans, For Fans"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Enabled = False
        Label9.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkGray
        Label9.Location = New Point(368, 112)
        Label9.Name = "Label9"
        Label9.Size = New Size(290, 33)
        Label9.TabIndex = 39
        Label9.Text = "ARTIST DASHBOARD"
        ' 
        ' artistDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1201, 516)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(analysisBtn)
        Controls.Add(venueBookingBtn)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "artistDashboard"
        Text = "artistDashboard"
        WindowState = FormWindowState.Maximized
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents venueBookingBtn As Button
    Friend WithEvents analysisBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
