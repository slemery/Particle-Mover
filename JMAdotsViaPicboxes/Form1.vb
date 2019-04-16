Public Class Form1

    ' add usual comments at top


    ' use Make Particle button a few times
    ' press STEP button to see them move
    ' only use START button if STEP is working
    ' make up to 50? particles whenever desired

    Dim ballw As Integer = 20           ' each particle is 20 by 20  change?
    Dim ballh As Integer = ballw

    Dim myParticle As New List(Of PictureBox)   '  holds array of particles
    Dim randbox As New Random
    Dim count As Integer = 0           ' counts particles
    Dim j As Integer

    Dim maxParticles As Integer = 50   '???

    ' arrays to hold x, y, and velocities for each particle
    Dim x(maxParticles), y(maxParticles) As Integer
    Dim xvel(maxParticles), yvel(maxParticles) As Integer

    Private Sub tmrA_Tick(sender As Object, e As EventArgs) Handles tmrA.Tick

        moveStuff()

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ballw = 20
        ballh = 20

        btnMake_Click(sender, e)    'creates ball 0

    End Sub

    Private Sub btnStep_Click(sender As Object, e As EventArgs) Handles btnStep.Click

        moveStuff()

    End Sub


    Private Sub moveStuff()

        For j = 0 To count - 1
            x(j) = myParticle(j).Location.X + xvel(j)
            y(j) = myParticle(j).Location.Y + yvel(j)

            ' add if statements to make particle bounce off edges
            ' if x(j) too low or too high, change x velocity 
            ' same idea for y(j) ...

            ' after edge bounces are working, change timer speed to run fast


            collisionChecker()      ' checks particle j vs particle k

            barchecker()    ' checks if any particle hits bar

            myParticle(j).SetBounds(x(j), y(j), ballw, ballh)
        Next j

    End Sub

    Private Sub Btnstop_Click(sender As Object, e As EventArgs) Handles Btnstop.Click
        tmrA.Stop() 'stops timer

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrA.Start()

    End Sub

    Private Sub collisionChecker()
        Dim j, k As Integer   'need local j and k

        ' check each particle against higher numbered ones
        ' if close enough to call a hit, change velocity of both.
        ' p1 is short for particle 1
        ' suppose p1 going up fast and right "hits" p4 going up slow and left.
        ' we swap velocities, so p1's xvel gets p4's xvel
        ' same for yvels
        ' result is p1 going up slow and left
        ' result is p4 going up fast and right

        ' not sure about all this code!
        For j = 0 To count - 2
            For k = 1 To count - 1
                If j = k Then
                    ' do nothing since we found a case like p3 vs p3
                Else
                    ' check for collision
                    If hit(j, k) Then   ' call function to see if pj hit pk

                        '    swap all relevant velocities for pj And pk



                    End If
                End If

            Next k

        Next j

    End Sub

    Private Function hit(jj As Integer, kk As Integer) As Boolean
        ' this function finds distance between particles jj and kk

        ' lots of code needed here


        Dim distance As Single
        ' dim all other local variables used below, as single

        ' calculate xdist as x(jj) - x(kk)
        ' calulate  ydist as yy(jj) - y(kk)
        ' calculate bigdistance as  xdist squared + ydist squared
        ' calculate distance as square root of bigdistance





        If distance < 30 Then       '???? maybe 25 or 30 or ?
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub barchecker()
        ' if used, add a picturebox that is a rectangle
        ' call it picBar
        ' calculate its left, right, top and bottom coords
        ' fudge is a variable set to 5? to help fudge the distance issues

        Dim j As Integer   'need local j 


        For j = 0 To count - 1
            ' see if particle j's x is between bar's left-fudge and right+fudge
            ' see if particle j's y is between bar's top-fudge and bottom+fudge
            ' if all that is true, the particle hit the bar
            ' so reverse its xvel  and its  yvel
            ' sometimes this logic doesn't quite work ...



        Next j


    End Sub


    Private Sub btnMake_Click(sender As Object, e As EventArgs) Handles btnMake.Click
        ' makes new picture of particle and adds to array list

        ' add check to see if count is 50 or more
        ' if so, skip all the code below (don't add another particle)


        Dim tempPicBox As New PictureBox()
        tempPicBox.Parent = PicA

        ' make the left and top values random, so the particles will
        ' likely appear at new locations

        tempPicBox.Left = 300
        tempPicBox.Top = 150
        tempPicBox.Image = picBall.Image
        tempPicBox.SizeMode = PictureBoxSizeMode.StretchImage
        tempPicBox.Visible = True

        tempPicBox.Width = ballw
        tempPicBox.Height = ballh

        myParticle.Add(tempPicBox)    'creates another ball in array

        xvel(count) = randbox.Next(-10, 11) ' random x speeds -- change ??
        yvel(count) = randbox.Next(-5, 6) ' random y speeds

        count += 1

    End Sub

End Class
