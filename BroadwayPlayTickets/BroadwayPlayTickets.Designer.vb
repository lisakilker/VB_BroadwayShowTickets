<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheatreTickets
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
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.lblBroadwayPlayTickets = New System.Windows.Forms.Label()
        Me.lblEnterNumberOfTickets = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.lblSubTotalGenerate = New System.Windows.Forms.Label()
        Me.lblTaxGenerate = New System.Windows.Forms.Label()
        Me.lblTotalGenerate = New System.Windows.Forms.Label()
        Me.radOrchestra = New System.Windows.Forms.RadioButton()
        Me.radMezzanine = New System.Windows.Forms.RadioButton()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.cboSelectPlay = New System.Windows.Forms.ComboBox()
        Me.txtEnterNumberOfTickets = New System.Windows.Forms.TextBox()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Image = Global.BroadwayPlayTickets.My.Resources.Resources.Broadway
        Me.picPicture.Location = New System.Drawing.Point(12, 12)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(202, 157)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'lblBroadwayPlayTickets
        '
        Me.lblBroadwayPlayTickets.AutoSize = True
        Me.lblBroadwayPlayTickets.BackColor = System.Drawing.Color.DarkRed
        Me.lblBroadwayPlayTickets.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBroadwayPlayTickets.ForeColor = System.Drawing.Color.White
        Me.lblBroadwayPlayTickets.Location = New System.Drawing.Point(260, 22)
        Me.lblBroadwayPlayTickets.Name = "lblBroadwayPlayTickets"
        Me.lblBroadwayPlayTickets.Size = New System.Drawing.Size(199, 22)
        Me.lblBroadwayPlayTickets.TabIndex = 1
        Me.lblBroadwayPlayTickets.Text = "Broadway Play Tickets"
        '
        'lblEnterNumberOfTickets
        '
        Me.lblEnterNumberOfTickets.AutoSize = True
        Me.lblEnterNumberOfTickets.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterNumberOfTickets.Location = New System.Drawing.Point(288, 96)
        Me.lblEnterNumberOfTickets.Name = "lblEnterNumberOfTickets"
        Me.lblEnterNumberOfTickets.Size = New System.Drawing.Size(142, 15)
        Me.lblEnterNumberOfTickets.TabIndex = 2
        Me.lblEnterNumberOfTickets.Text = "Enter Number of Tickets:"
        Me.lblEnterNumberOfTickets.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(263, 238)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(61, 15)
        Me.lblSubTotal.TabIndex = 3
        Me.lblSubTotal.Text = "Sub Total:"
        Me.lblSubTotal.Visible = False
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(263, 263)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 15)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "Tax:"
        Me.lblTax.Visible = False
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.Location = New System.Drawing.Point(263, 288)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(36, 15)
        Me.lblFinalTotal.TabIndex = 5
        Me.lblFinalTotal.Text = "Total:"
        Me.lblFinalTotal.Visible = False
        '
        'lblSubTotalGenerate
        '
        Me.lblSubTotalGenerate.AutoSize = True
        Me.lblSubTotalGenerate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalGenerate.Location = New System.Drawing.Point(386, 238)
        Me.lblSubTotalGenerate.Name = "lblSubTotalGenerate"
        Me.lblSubTotalGenerate.Size = New System.Drawing.Size(52, 15)
        Me.lblSubTotalGenerate.TabIndex = 6
        Me.lblSubTotalGenerate.Text = "$888.88"
        Me.lblSubTotalGenerate.Visible = False
        '
        'lblTaxGenerate
        '
        Me.lblTaxGenerate.AutoSize = True
        Me.lblTaxGenerate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxGenerate.Location = New System.Drawing.Point(386, 263)
        Me.lblTaxGenerate.Name = "lblTaxGenerate"
        Me.lblTaxGenerate.Size = New System.Drawing.Size(52, 15)
        Me.lblTaxGenerate.TabIndex = 7
        Me.lblTaxGenerate.Text = "$888.88"
        Me.lblTaxGenerate.Visible = False
        '
        'lblTotalGenerate
        '
        Me.lblTotalGenerate.AutoSize = True
        Me.lblTotalGenerate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGenerate.Location = New System.Drawing.Point(386, 288)
        Me.lblTotalGenerate.Name = "lblTotalGenerate"
        Me.lblTotalGenerate.Size = New System.Drawing.Size(52, 15)
        Me.lblTotalGenerate.TabIndex = 8
        Me.lblTotalGenerate.Text = "$888.88"
        Me.lblTotalGenerate.Visible = False
        '
        'radOrchestra
        '
        Me.radOrchestra.AutoSize = True
        Me.radOrchestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrchestra.Location = New System.Drawing.Point(264, 173)
        Me.radOrchestra.Name = "radOrchestra"
        Me.radOrchestra.Size = New System.Drawing.Size(74, 18)
        Me.radOrchestra.TabIndex = 9
        Me.radOrchestra.TabStop = True
        Me.radOrchestra.Text = "Orchestra"
        Me.radOrchestra.UseVisualStyleBackColor = True
        Me.radOrchestra.Visible = False
        '
        'radMezzanine
        '
        Me.radMezzanine.AutoSize = True
        Me.radMezzanine.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMezzanine.Location = New System.Drawing.Point(264, 197)
        Me.radMezzanine.Name = "radMezzanine"
        Me.radMezzanine.Size = New System.Drawing.Size(77, 18)
        Me.radMezzanine.TabIndex = 10
        Me.radMezzanine.TabStop = True
        Me.radMezzanine.Text = "Mezzanine"
        Me.radMezzanine.UseVisualStyleBackColor = True
        Me.radMezzanine.Visible = False
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.BackColor = System.Drawing.Color.DarkRed
        Me.btnCalculateCost.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.ForeColor = System.Drawing.Color.White
        Me.btnCalculateCost.Location = New System.Drawing.Point(387, 173)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(75, 42)
        Me.btnCalculateCost.TabIndex = 11
        Me.btnCalculateCost.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = False
        Me.btnCalculateCost.Visible = False
        '
        'cboSelectPlay
        '
        Me.cboSelectPlay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectPlay.FormattingEnabled = True
        Me.cboSelectPlay.Items.AddRange(New Object() {"Lion King", "Wicked", "Phantom of the Opera"})
        Me.cboSelectPlay.Location = New System.Drawing.Point(272, 64)
        Me.cboSelectPlay.Name = "cboSelectPlay"
        Me.cboSelectPlay.Size = New System.Drawing.Size(175, 22)
        Me.cboSelectPlay.TabIndex = 12
        '
        'txtEnterNumberOfTickets
        '
        Me.txtEnterNumberOfTickets.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterNumberOfTickets.Location = New System.Drawing.Point(342, 121)
        Me.txtEnterNumberOfTickets.Name = "txtEnterNumberOfTickets"
        Me.txtEnterNumberOfTickets.Size = New System.Drawing.Size(34, 20)
        Me.txtEnterNumberOfTickets.TabIndex = 13
        Me.txtEnterNumberOfTickets.Visible = False
        '
        'frmTheatreTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 316)
        Me.Controls.Add(Me.txtEnterNumberOfTickets)
        Me.Controls.Add(Me.cboSelectPlay)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.radMezzanine)
        Me.Controls.Add(Me.radOrchestra)
        Me.Controls.Add(Me.lblTotalGenerate)
        Me.Controls.Add(Me.lblTaxGenerate)
        Me.Controls.Add(Me.lblSubTotalGenerate)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblEnterNumberOfTickets)
        Me.Controls.Add(Me.lblBroadwayPlayTickets)
        Me.Controls.Add(Me.picPicture)
        Me.Name = "frmTheatreTickets"
        Me.Text = "Broadway Theatre Tickets"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblBroadwayPlayTickets As System.Windows.Forms.Label
    Friend WithEvents lblEnterNumberOfTickets As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblFinalTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalGenerate As System.Windows.Forms.Label
    Friend WithEvents lblTaxGenerate As System.Windows.Forms.Label
    Friend WithEvents lblTotalGenerate As System.Windows.Forms.Label
    Friend WithEvents radOrchestra As System.Windows.Forms.RadioButton
    Friend WithEvents radMezzanine As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents cboSelectPlay As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnterNumberOfTickets As System.Windows.Forms.TextBox

End Class
