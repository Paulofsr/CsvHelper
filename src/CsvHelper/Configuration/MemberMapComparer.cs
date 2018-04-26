﻿// Copyright 2009-2017 Josh Close and Contributors
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper
using System;
using System.Collections.Generic;

namespace CsvHelper.Configuration
{
	/// <summary>
	/// Used to compare <see cref="MemberMap"/>s.
	/// The order is by field index ascending. Any
	/// fields that don't have an index are pushed
	/// to the bottom.
	/// </summary>
	internal class MemberMapComparer : IComparer<MemberMap>
	{
		public virtual int Compare( object x, object y )
		{
			var xMember = x as MemberMap;
			var yMember = y as MemberMap;
			return Compare( xMember, yMember );
		}

		public virtual int Compare( MemberMap x, MemberMap y )
		{
			if( x == null )
			{
				throw new ArgumentNullException( nameof( x ) );
			}
			if( y == null )
			{
				throw new ArgumentNullException( nameof( y ) );
			}

			return x.Data.Index.CompareTo( y.Data.Index );
		}
	}
}
