// Copyright (C) 2011 Zeno Gantner
//
// This file is part of MyMediaLite.
//
// MyMediaLite is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// MyMediaLite is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with MyMediaLite.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Linq;

namespace MyMediaLite.DataType
{
	/// <summary>Utilities to work with matrices</summary>
	public static class SparseMatrixUtils
	{
		/// <summary>return the maximum value contained in a matrix</summary>
		/// <param name='m'>the matrix</param>
		static public int Max(SparseMatrix<int> m)
		{
			if (m.row_list.Count == 0)
				return 0;
			else
				return m.row_list.Max(r => (r.Values.Count == 0 ? 0 : r.Values.Max()));
		}

		/// <summary>return the maximum value contained in a matrix</summary>
		/// <param name='m'>the matrix</param>
		static public double Max(SparseMatrix<double> m)
		{
			if (m.row_list.Count == 0)
				return 0.0;
			else
				return m.row_list.Max(r => (r.Values.Count == 0 ? 0 : r.Values.Max()));
		}

		/// <summary>return the maximum value contained in a matrix</summary>
		/// <param name='m'>the matrix</param>
		static public float Max(SparseMatrix<float> m)
		{
			if (m.row_list.Count == 0)
				return 0.0f;
			else
				return m.row_list.Max(r => (r.Values.Count == 0 ? 0 : r.Values.Max()));
		}
	}
}