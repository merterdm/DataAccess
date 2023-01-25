﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.Abstract
{
	public enum Status
	{
		Active=1,
		Update=2,
		Delete=3
	}

	public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

		private DateTime _CreateDate=DateTime.Now;

		public DateTime CreateDate
		{
			get { return _CreateDate; }
			set { _CreateDate= value; }
		}

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }


        private Status _status=Status.Active;

		public Status Status
		{
			get { return _status; }
			set { _status= value; }
		}

	}
}
