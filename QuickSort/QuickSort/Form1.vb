

Public Class Form1
    Dim i, Pivot, Pi, tmp, Lst()


    Function Partition(sort_list, low, high)
        i = (low - 1)
        Pivot = sort_list(high)

        For j = low + 1 To high + 1
            If sort_list(j - 1) <= Pivot Then
                i += 1
                tmp = sort_list(i)
                sort_list(i) = sort_list(j - 1)
                sort_list(j - 1) = tmp
            End If
        Next

        tmp = sort_list(i + 1)
        sort_list(i + 1) = sort_list(high)
        sort_list(high) = tmp

        Return (i + 1)

    End Function

    Sub Quick_Sort(sort_list, low, high)

        If low < high Then
            Pi = Partition(sort_list, low, high)
            Quick_Sort(sort_list, low, Pi - 1)
        ElseIf low > high Then
            Quick_Sort(sort_list, Pi + 1, high)
        End If

    End Sub


    'lst = []
    'size = int(input("Enter size of the list: "))

    'For i in range(size):
    '    elements = int(input("Enter an element"))
    '    lst.append(elements)

    'low = 0
    'high = len(lst) - 1
    'quick_sort(lst, low, high)
    'print(lst)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox2.Clear()
        ReDim Lst(TextBox1.TextLength)
        For z = 0 To TextBox1.TextLength - 1

            Lst(z) = Mid(TextBox1.Text, z + 1, 1)

        Next
        Dim LL = 0, HH = Lst.Length - 2

        Call Quick_Sort(Lst, LL, HH)

        For z = 0 To Lst.Length - 1
            TextBox2.Text &= Lst(z)
        Next

    End Sub

End Class
