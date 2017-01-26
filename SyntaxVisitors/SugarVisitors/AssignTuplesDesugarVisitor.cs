﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PascalABCCompiler.SyntaxTree;

namespace SyntaxVisitors.SugarVisitors
{
    public class AssignTuplesDesugarVisitor : BaseChangeVisitor
    {
        public static AssignTuplesDesugarVisitor New
        {
            get { return new AssignTuplesDesugarVisitor(); }
        }

        private int num = 0;

        public string UniqueNumStr()
        {
            num++;
            return num.ToString();
        }

        public override void visit(assign_tuple asstup)
        {
            var sl = new statement_list();
            sl.Add(new semantic_check_sugared_statement_node(asstup)); // Это нужно для проверок на этапе преобразования в семантику

            var tname = "#temp_var" + UniqueNumStr();
            var tt = new var_statement(new ident(tname), asstup.expr);
            sl.Add(tt);

            var n = asstup.vars.variables.Count();
            for (var i = 0; i < n; i++)
            {
                var a = new assign(asstup.vars.variables[i], new dot_node(new ident(tname),
                    new ident("Item" + (i + 1).ToString())), Operators.Assignment,
                    asstup.vars.variables[i].source_context);
                sl.Add(a);
            }
            // Замена 1 оператор на 1 оператор - всё OK
            ReplaceUsingParent(asstup, sl);

            visit(asstup.expr);
        }

        public override void visit(assign_var_tuple assvartup)
        {
            var sl = new List<statement>();
            sl.Add(new semantic_check_sugared_statement_node(assvartup)); // Это нужно для проверок на этапе преобразования в семантику

            var tname = "#temp_var" + UniqueNumStr();
            var tt = new var_statement(new ident(tname), assvartup.expr); // тут для assvartup.expr внутри повторно вызывается convert_strong, это плохо, но если там лямбда, то иначе - с semantic_addr_value - не работает!!!
            sl.Add(tt); // он же помещается в новое синтаксическое дерево

            var n = assvartup.vars.variables.Count();
            for (var i = 0; i < n; i++)
            {
                var a = new var_statement(assvartup.vars.variables[i] as ident,
                    new dot_node(new ident(tname), new ident("Item" + (i + 1).ToString())),
                    assvartup.vars.variables[i].source_context);
                sl.Add(a);
            }
            ReplaceStatementUsingParent(assvartup, sl);

            visit(assvartup.expr); // В assvartup.expr могут содержаться лямбды, в которых будут другие assign_var_tuple. 
            // И вообще другой синтаксический сахар, размещённый в этом визиторе
        }
    }
}