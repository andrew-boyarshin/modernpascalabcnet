﻿// Copyright (c) Ivan Bondarev, Stanislav Mihalkovich (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using PascalSharp.Internal.SemanticTree;

namespace PascalSharp.Internal.TreeConverter.TreeRealization
{
    /// <summary>
    /// Класс для представления позиций частей кода в дереве.
    /// </summary>
	[Serializable]
	public class location : ILocation
	{
        /// <summary>
        /// Номер строки начала фрагмента кода (нумерация начинается с 1).
        /// </summary>
		private int _begin_line_num;

        /// <summary>
        /// Номер колонки начала фрагмента кода (нумерация начинается с 1).
        /// </summary>
		private int _begin_column_num;

        /// <summary>
        /// Номер строки конца фрагмента кода (нумерация начинается с 1).
        /// </summary>
		private int _end_line_num;

        /// <summary>
        /// Номер колонки конца фрагмента кода (нумерация начинается с 1).
        /// </summary>
		private int _end_column_num;

        /// <summary>
        /// Документ, в котором расположен этот фрагмент кода.
        /// </summary>
		private document _doc;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="begin_line_num">Номер строки начала фрагмента кода (нумерация начинается с 1).</param>
        /// <param name="begin_column_num">Номер колонки начала фрагмента кода (нумерация начинается с 1).</param>
        /// <param name="end_line_num">Номер строки конца фрагмента кода (нумерация начинается с 1).</param>
        /// <param name="end_column_num">Номер колонки конца фрагмента кода (нумерация начинается с 1)</param>
        /// <param name="doc">Документ, в котором расположен этот фрагмент кода.</param>
		public location(int begin_line_num, int begin_column_num,int end_line_num,int end_column_num,document doc)
		{
			_begin_line_num=begin_line_num;
			_begin_column_num=begin_column_num;
			_end_line_num=end_line_num;
			_end_column_num=end_column_num;
			_doc=doc;
		}

        /// <summary>
        /// Номер строки начала фрагмента кода (нумерация начинается с 1).
        /// </summary>
		public int begin_line_num
		{
			get
			{
				return _begin_line_num;
			}
			set
			{
				_begin_line_num = value;
			}
		}

        /// <summary>
        /// Номер колонки начала фрагмента кода (нумерация начинается с 1).
        /// </summary>
		public int begin_column_num
		{
			get
			{
				return _begin_column_num;
			}
			set
			{
				_begin_column_num = value;
			}
		}

        /// <summary>
        /// Номер строки конца фрагмента кода (нумерация начинается с 1).
        /// </summary>
		public int end_line_num
		{
			get
			{
				return _end_line_num;
			}
			set
			{
				_end_line_num = value;
			}
		}

        /// <summary>
        /// Номер колонки конца фрагмента кода (нумерация начинается с 1).
        /// </summary>
		public int end_column_num
		{
			get
			{
				return _end_column_num;
			}
			set
			{
				_end_column_num = value;
			}
		}

        /// <summary>
        /// Документ, в котором расположен этот фрагмент кода.
        /// </summary>
		public document doc
		{
			get
			{
				return _doc;
			}
			set
			{
				_doc = value;
			}
		}

        /// <summary>
        /// Документ, в котором расположен этот фрагмент кода.
        /// </summary>
		public IDocument document
		{
			get
			{
				return _doc;
			}
		}

		public override string ToString()
		{
			string res="File:  "+doc.ToString();
			res+="  line:  "+begin_line_num.ToString();
			res+="  column:  "+begin_column_num.ToString();
			return res;
		}
	}

}
