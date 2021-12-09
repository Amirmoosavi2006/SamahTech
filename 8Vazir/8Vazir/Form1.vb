Public Class Form1


	'
	'* This function generates a new Entity object
	'
	'C++ TO VB CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	'ORIGINAL LINE: Entity* Entity::generate_random_entity()

	Public Class GlobalMembers
		Public Shared Function fitness_function(ByVal e As Entity) As Single
			Dim threats As Integer = 0
			' total possible threats = C(2, 8) = 28
			' this value is for 8 queens
			Const total_posible_threats As Integer = 28
			For col As Integer = 0 To Entity.COUNT_COLUMN - 1
				Dim col_val As Integer = e.get_column(col)
				For ptr As Integer = col + 1 To Entity.COUNT_COLUMN - 1
					Dim ptr_val As Integer = e.get_column(ptr)
					If col_val = ptr_val Then
						' in same row
						threats += 1
					ElseIf ptr - col = ptr_val - col_val Then
						' diagonal  `/`
						threats += 1
					ElseIf ptr - col = col_val - ptr_val Then
						' diagonal `\`
						threats += 1
					End If
				Next ptr
			Next col
			Return 1 - (threats / CSng(total_posible_threats))
		End Function

		Public Shared generator As New default_random_engine()
'C++ TO VB CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
	uniform_int_distribution(Of Integer) Entity.distribution(0, COUNT_ROW-1)

	Public Shared Function generate_random_population(ByVal size As Integer) As Entity()
			Dim population() As Entity = Arrays.InitializeWithDefaultInstances(Of Entity)(size)
			Dim e As Entity
			For i As Integer = 0 To size - 1
				e = Entity.generate_random_entity()
				'C++ TO VB CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
				'ORIGINAL LINE: population[i] = *e;
				population(i).CopyFrom(e)
			Next i
			Return population
		End Function

		Public Shared Function select_from_population(ByVal population() As Entity, ByVal size As Integer) As Entity()
			Dim comulative_f(size - 1) As Single
			Dim normal_f As Single
			Dim comulative As Single = 0
			Dim total_f As Single = 0
			' calculate sum of f value for normalization
			For i As Integer = 0 To size - 1
				total_f += fittness_function(population(i))
			Next i
			' generate the commulative value
			For i As Integer = 0 To size - 1
				'C++ TO VB CONVERTER WARNING: C++ to VB Converter cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
				normal_f = fittness_function(population(i)) / total_f
				comulative += normal_f
				comulative_f(i) = comulative
			Next i
			' select parents randomly with
			' respect to fittness
			Dim selected() As Entity = Arrays.InitializeWithDefaultInstances(Of Entity)(size)
			Dim max_rnd As Double = CDbl(RAND_MAX) + 1
			For i As Integer = 0 To size - 1
				'C++ TO VB CONVERTER WARNING: C++ to VB Converter cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
				Dim rnd As Double = RandomNumbers.NextNumber() / max_rnd
				Dim ptr As Integer = 0
				Do While ptr < size - 1
					If comulative_f(ptr) >= rnd Then
						Exit Do
					End If
					ptr += 1
				Loop
				'C++ TO VB CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
				'ORIGINAL LINE: selected[i] = population[ptr];
				selected(i).CopyFrom(population(ptr))
			Next i
			Return selected
		End Function

		Public Shared Function cross_over(ByVal population() As Entity, ByVal size As Integer) As Entity()
			If size Mod 2 <> 0 Then
				Throw New System.ArgumentException("population size is not even number!")
			End If
			Dim result() As Entity = Arrays.InitializeWithDefaultInstances(Of Entity)(size \ 2)
			Dim pop_index As Integer = 0
			For i As Integer = 0 To size - 1 Step 2
				Dim xover As New Entity()
				Dim xover_pnt As Integer = RandomNumbers.NextNumber() Mod Entity.COUNT_COLUMN
				For j As Integer = 0 To Entity.COUNT_COLUMN - 1
					Dim val As Integer
					If j <= xover_pnt Then
						val = population(i).get_column(j)
					Else
						val = population(i + 1).get_column(j)
					End If
					xover.set_column_row(j, val)
				Next j
				'C++ TO VB CONVERTER WARNING: An assignment within expression was extracted from the following statement:
				'ORIGINAL LINE: result[pop_index++] = *xover;
				'C++ TO VB CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
				result(pop_index).CopyFrom(xover)
				pop_index += 1
			Next i
			Return result
		End Function


	End Class

	Partial Public Class Entity
		Public Function generate_random_entity() As Entity
			Dim entity As New Entity()
			For col As Integer = 0 To COUNT_COLUMN - 1
				Dim row As Integer = distribution(GlobalMembers.generator)
				entity.set_column_row(col, row)
			Next col
			Return entity
		End Function
	End Class

	'Helper class added by C++ to VB Converter:

	'----------------------------------------------------------------------------------------
	'	Copyright © 2006 - 2020 Tangible Software Solutions, Inc.
	'	This module can be used by anyone provided that the copyright notice remains intact.
	'
	'	This module provides the ability to initialize and delete array elements.
	'----------------------------------------------------------------------------------------
	Friend Module Arrays
		Public Function InitializeWithDefaultInstances(Of T As New)(ByVal length As Integer) As T()
			Dim array(length - 1) As T
			For i As Integer = 0 To length - 1
				array(i) = New T()
			Next i
			Return array
		End Function

		Public Sub DeleteArray(Of T As IDisposable)(ByVal array() As T)
			For Each element As T In array
				If element IsNot Nothing Then
					element.Dispose()
				End If
			Next element
		End Sub
	End Module

	'Helper class added by C++ to VB Converter:

	'----------------------------------------------------------------------------------------
	'	Copyright © 2006 - 2020 Tangible Software Solutions, Inc.
	'	This module can be used by anyone provided that the copyright notice remains intact.
	'
	'	This module provides the ability to replicate the behavior of the C/C++ functions for 
	'	generating random numbers, using the .NET Framework System.Random class.
	'	'rand' converts to the parameterless overload of NextNumber
	'	'random' converts to the single-parameter overload of NextNumber
	'	'randomize' converts to the parameterless overload of Seed
	'	'srand' converts to the single-parameter overload of Seed
	'----------------------------------------------------------------------------------------
	Friend Module RandomNumbers
		Private r As System.Random

		Public Function NextNumber() As Integer
			If r Is Nothing Then
				Seed()
			End If

			Return r.Next()
		End Function

		Public Function NextNumber(ByVal ceiling As Integer) As Integer
			If r Is Nothing Then
				Seed()
			End If

			Return r.Next(ceiling)
		End Function

		Public Sub Seed()
			r = New System.Random()
		End Sub

		Public Sub Seed(ByVal seed As Integer)
			r = New System.Random(seed)
		End Sub
	End Module



End Class