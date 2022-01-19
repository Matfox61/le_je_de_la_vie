Public Class Form1
    Private Const TAILLE As Integer = 15
    Dim MoteurUI As New Moteur
    Dim listeVivants As ArrayList = New ArrayList
    Dim nbBoutons As Integer = 20
    Dim regleNbVivants As Integer
    Dim regleNbMorts As Integer
    Dim nbVivants As Integer = 0
    Dim boutons(19, 19) As Button



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoteurUI.timer.Interval = 1000               ' Définit le tick de l'horloge à 1s
        MoteurUI.setRegles()
        creerGrille()

    End Sub

    Private Function creerGrille()
        For column As Integer = 0 To nbBoutons - 1
            For row As Integer = 0 To nbBoutons - 1
                Dim btn As New Button       'Créer des boutons
                btn.Height = TAILLE         ' On définit la taille des boutons
                btn.Width = TAILLE
                aleatoire(btn)
                panel.Controls.Add(btn, column, row)         ' Ajouter le bouton par rapport à lignes et colonnes
                boutons(column, row) = btn                      ' Ajouter le bouton dans le tablal
                AddHandler btn.Click, AddressOf BoutonClique     ' Appel de la fonction BoutonClique lorsque l'on clique sur le bouton

            Next
        Next
    End Function


    Private Sub BtnLecture_Click(sender As Object, e As EventArgs) Handles btnLecture.Click
        ' En cliquant sur le bouton lecture on active le timer et on lance le moteur du jeu
        MoteurUI.timer.Enabled = True
        MoteurUI.etatSuivant()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        ' En cliquant sur le bouton stop on arrête le timer
        MoteurUI.timer.Enabled = False
    End Sub

    Function aleatoire(btn As Button)
        Dim vivant As Integer
        vivant = Int((2 * Rnd()) + 1)       ' Prend un nombre aléatoire entre 1 et 2 
        If vivant = 1 Then
            btn.BackColor = Color.FromName("Black") ' Si c'est 1 alors la cellule est vivante
        Else
            btn.BackColor = Color.FromName("White") ' Sinon elle est morte
        End If
    End Function

    Private Sub BtnAleatoire_Click(sender As Object, e As EventArgs) Handles btnAleatoire.Click
        ' Appel la fonction aléatoire lorsque l'on clique sur le bouton

        For i As Integer = 0 To nbBoutons - 1
            For j As Integer = 0 To nbBoutons - 1
                aleatoire(boutons(i, j))
            Next
        Next
        afficheVivants()
    End Sub

    Private Function afficheVivants()
        nbVivants = 0
        For i As Integer = 0 To nbBoutons - 1
            For j As Integer = 0 To nbBoutons - 1
                ' Parcours le tableau pour compter le nombre de cellules noires donc vivantes
                If boutons(i, j).BackColor = Color.FromName("Black") Then
                    nbVivants = nbVivants + 1
                End If
            Next
        Next
        lblNbVivantes.Text = CStr(nbVivants)
    End Function

    Sub BoutonClique(sender As Object, e As EventArgs)
        ' Lorsque l'on clique sur un bouton spécifique, celui-ci change de couleur
        If TypeOf sender Is Button Then                 ' On vérifie que le sender est bien de type bouton
            Dim temp As Button = CType(sender, Button)  ' ON le convertit de objet en bouton pour avoir toutes les actions possibles sur bouton
            If temp.BackColor = Color.FromName("White") Then
                temp.BackColor = Color.FromName("Black")
            Else
                temp.BackColor = Color.FromName("White")
            End If
            afficheVivants()
        End If
    End Sub

    Protected Class Moteur
        Dim minMort, maxMort, minNaissance, maxNaissance As Integer
        Dim grille As TableLayoutPanel
        'Dim tabBtn(grille.RowCount, grille.ColumnCount) As Button
        Public nbVie, nbMort As Integer
        'Dim listeB, listeW As ArrayList
        Public WithEvents timer As Timer = New Timer




        Public Sub setRegles()
            ' Récupère le nombre de morts et de vivants min et max entré par l'utilisateur
            minMort = CInt(Form1.txtMinMorts.Text)
            maxMort = CInt(Form1.txtMaxMorts.Text)
            minNaissance = CInt(Form1.txtMinVivants.Text)
            maxNaissance = CInt(Form1.txtMaxVivants.Text)
        End Sub

        Private Sub setEtatCellule(i As Integer, j As Integer, etat As Boolean)
            If etat Then
                Form1.boutons(i, j).BackColor = Color.Black
            Else
                Form1.boutons(i, j).BackColor = Color.White
            End If

        End Sub

        Public Function getEtatCellule(i As Integer, j As Integer)
            Return Form1.boutons(i, j).BackColor
        End Function

        Sub etatSuivant() Handles timer.Tick
            'Les 8 cellules qui entourent la cellule sélectionnée
            Dim tabCellules(7) As Button
            On Error Resume Next
            For i As Integer = 0 To 19
                For j As Integer = 0 To 19
                    nbVie = 0
                    nbMort = 0

                    tabCellules(0) = Form1.boutons(i - 1, j - 1)
                    tabCellules(1) = Form1.boutons(i, j - 1)
                    tabCellules(2) = Form1.boutons(i + 1, j - 1)
                    tabCellules(3) = Form1.boutons(i - 1, j)
                    tabCellules(4) = Form1.boutons(i + 1, j)
                    tabCellules(5) = Form1.boutons(i - 1, j + 1)
                    tabCellules(6) = Form1.boutons(i, j + 1)
                    tabCellules(7) = Form1.boutons(i + 1, j + 1)

                    For k As Integer = 0 To 7
                        If tabCellules(k) Is Nothing Then
                            On Error Resume Next
                        ElseIf tabCellules(k).BackColor = Color.Black Then
                            nbVie += 1
                        Else
                            nbMort += 1
                        End If
                    Next

                    If nbVie >= minNaissance And nbVie <= maxNaissance Then
                        Form1.boutons(i, j).BackColor = Color.Black

                        'ElseIf nbMort >= minMort And nbMort <= maxMort Then
                    Else

                        Form1.boutons(i, j).BackColor = Color.White
                    End If
                    Form1.afficheVivants()
                Next
            Next
        End Sub
    End Class

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        MoteurUI.setRegles()
    End Sub
End Class

