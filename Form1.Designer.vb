<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.dgusers = New System.Windows.Forms.DataGridView()
        Me.User_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnloadusers = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgusers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txtuserid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 363)
        Me.Panel1.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(12, 165)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(130, 38)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add To Database"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(12, 118)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(265, 29)
        Me.txtname.TabIndex = 1
        '
        'txtuserid
        '
        Me.txtuserid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(12, 55)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(265, 29)
        Me.txtuserid.TabIndex = 0
        '
        'dgusers
        '
        Me.dgusers.AllowUserToAddRows = False
        Me.dgusers.AllowUserToDeleteRows = False
        Me.dgusers.BackgroundColor = System.Drawing.Color.White
        Me.dgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgusers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User_ID, Me.Username})
        Me.dgusers.Location = New System.Drawing.Point(309, 55)
        Me.dgusers.Name = "dgusers"
        Me.dgusers.ReadOnly = True
        Me.dgusers.Size = New System.Drawing.Size(274, 206)
        Me.dgusers.TabIndex = 1
        '
        'User_ID
        '
        Me.User_ID.HeaderText = "User_ID"
        Me.User_ID.Name = "User_ID"
        Me.User_ID.ReadOnly = True
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'btnloadusers
        '
        Me.btnloadusers.Location = New System.Drawing.Point(309, 11)
        Me.btnloadusers.Name = "btnloadusers"
        Me.btnloadusers.Size = New System.Drawing.Size(130, 38)
        Me.btnloadusers.TabIndex = 3
        Me.btnloadusers.Text = "Load Users"
        Me.btnloadusers.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(164, 165)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 38)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(15, 222)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 39)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 363)
        Me.Controls.Add(Me.btnloadusers)
        Me.Controls.Add(Me.dgusers)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgusers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents dgusers As DataGridView
    Friend WithEvents User_ID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents btnloadusers As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
