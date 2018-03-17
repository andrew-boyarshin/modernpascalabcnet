﻿// Copyright (c) Ivan Bondarev, Stanislav Mihalkovich (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

namespace PascalSharp.Internal.SyntaxTree.Visitors.YieldVisitors
{
    public class ReplaceBreakContinueWithGotoLabelVisitor : BaseChangeVisitor
    {
        public goto_statement GotoContinue { get; private set; }
        public goto_statement GotoBreak { get; private set; }

        public ReplaceBreakContinueWithGotoLabelVisitor(goto_statement gotoContinue, goto_statement gotoBreak)
        {
            this.GotoContinue = gotoContinue;
            this.GotoBreak = gotoBreak;
        }

        public override void Enter(syntax_tree_node st)
        {
            base.Enter(st);
            // Не заходим во вложенные циклы, там свои break-continue
            if ((st is for_node || st is foreach_stmt || st is while_node || st is repeat_node))
            {
                visitNode = false;
            }
        }

        public override void visit(procedure_call pc)
        {
            var pcIdent = pc.func_name as ident;
            if (pcIdent != null)
            {
                var pcName = pcIdent.name.ToLower();
                if (pcName == "break")
                {
                    Replace(pc, this.GotoBreak);
                }
                else if (pcName == "continue")
                {
                    Replace(pc, this.GotoContinue);
                }
            }
        }
    }
}
