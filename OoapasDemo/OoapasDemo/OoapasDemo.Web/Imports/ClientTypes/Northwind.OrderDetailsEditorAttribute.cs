﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace OoapasDemo.Northwind {
    public partial class OrderDetailsEditorAttribute : CustomEditorAttribute {
        public const string Key = "OoapasDemo.Northwind.OrderDetailsEditor";

        public OrderDetailsEditorAttribute()
            : base(Key) {
        }
    }
}
