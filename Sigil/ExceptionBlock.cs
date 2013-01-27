﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigil
{
    /// <summary>
    /// Represents an ExceptionBlock, which is roughly analogous to a try + catch + finally block in C#.
    /// 
    /// To create an ExceptionBlock call BeginExceptionBlock().
    /// </summary>
    public class ExceptionBlock
    {
        internal object Owner { get { return Label.Owner; } }

        /// <summary>
        /// A label which marks the end of the ExceptionBlock.
        /// 
        /// This Label is meant to be targetted by Leave() from anywhere except a FinallyBlock
        /// in the ExceptionBlock.
        /// 
        /// Remember that it is illegal to branch from within an ExceptionBlock to outside.
        /// </summary>
        public Label Label { get; private set; }

        internal ExceptionBlock(Label label)
        {
            Label = label;
        }
    }
}
