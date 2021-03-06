﻿// Copyright (c) Ivan Bondarev, Stanislav Mihalkovich (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using PascalSharp.Internal.SemanticTree;
using PascalSharp.Internal.TreeConverter.NetWrappers;

namespace PascalSharp.Internal.TreeConverter.TreeRealization
{
    /// <summary>
    /// Класс, представляющий определение константы.
    /// </summary>
    [Serializable]
    public abstract class constant_definition_node : definition_node, IConstantDefinitionNode
    {
        /// <summary>
        /// Имя константы.
        /// </summary>
        private readonly string _name;
                
        /// <summary>
        /// Значение константы.
        /// </summary>
        private constant_node _cn;

        /// <summary>
        /// Место, где определена константа.
        /// </summary>
        private readonly location _loc;

        /// <summary>
        /// Конструктор узла.
        /// </summary>
        /// <param name="name">Имя константы.</param>
        /// <param name="loc">Расположение константы.</param>
        public constant_definition_node(string name, location loc)
        {
            _name = name;
            _loc = loc;
        }

        /// <summary>
        /// Конструктор узла.
        /// </summary>
        /// <param name="name">Имя константы.</param>
        /// <param name="cn">Значение константы.</param>
        /// <param name="loc">Расположение константы.</param>
        public constant_definition_node(string name, constant_node cn, location loc)
        {
            _name = name;
            _cn = cn;
            _loc = loc;
        }

        /// <summary>
        /// Место, где определена константа.
        /// Это свойство используется при генерации дерева.
        /// </summary>
        public location loc
        {
            get
            {
                return _loc;
            }
        }

        /// <summary>
        /// Место, где определена константа.
        /// Это свойство используется при обходе дерева посетителем.
        /// </summary>
        public ILocation Location
        {
            get
            {
                return loc;
            }
        }

        /// <summary>
        /// Имя константы.
        /// </summary>
        public string name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Тип константы.
        /// </summary>
        public type_node type
        {
            get
            {
                return _cn.type;
            }
        }

        /// <summary>
        /// Значение константы.
        /// </summary>
        public constant_node const_value
        {
            get
            {
                return _cn;
            }
            set
            {
                _cn = value;
            }
        }

        /// <summary>
        /// Обобщенный тип узла.
        /// </summary>
        public override general_node_type general_node_type
        {
            get
            {
                return general_node_type.constant_definition;
            }
        }

        /// <summary>
        /// Метод для обхода дерева посетителем.
        /// </summary>
        /// <param name="visitor">Класс - посетитель дерева.</param>
        public override void visit(ISemanticVisitor visitor)
        {
            visitor.visit(this);
        }

        /// <summary>
        /// Тип константы.
        /// Используется при обходе дерева посетителем.
        /// </summary>
        ITypeNode IConstantDefinitionNode.type
        {
            get
            {
                return _cn.type;
            }
        }

        /// <summary>
        /// Значение константы.
        /// Используется при обходе дерева посетителем.
        /// </summary>
        public IConstantNode constant_value
        {
            get
            {
                return _cn;
            }
        }
    }

    //TODO: Возможно стоит сделать шаблонный тип для всех видов определений констант.
    /// <summary>
    /// Класс, представляющий определение константы в пространстве имен.
    /// </summary>
    [Serializable]
    public class namespace_constant_definition : constant_definition_node, INamespaceConstantDefinitionNode
    {
        /// <summary>
        /// Пространство имен в котором определена константа.
        /// </summary>
        private readonly common_namespace_node _comprehensive_namespace;

        public namespace_constant_definition(string name, location loc, common_namespace_node comprehensive_namespace) :
            base(name, loc)
        {
            _comprehensive_namespace = comprehensive_namespace;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя константы.</param>
        /// <param name="cn">Значени константы.</param>
        /// <param name="loc">Расположение определения константы.</param>
        /// <param name="comprehensive_namespace">Пространство имен в котором определена константа.</param>
        public namespace_constant_definition(string name, constant_node cn, location loc, common_namespace_node comprehensive_namespace) :
            base(name,cn,loc)
        {
            _comprehensive_namespace = comprehensive_namespace;
        }

        /// <summary>
        /// Пространство имен в котором определена константа.
        /// </summary>
        public common_namespace_node comprehensive_namespace
        {
            get
            {
                return _comprehensive_namespace;
            }
        }

        /// <summary>
        /// Метод для обхода дерева посетителем.
        /// </summary>
        /// <param name="visitor">Класс - посетитель дерева.</param>
        public override void visit(ISemanticVisitor visitor)
        {
            visitor.visit(this);
        }

        /// <summary>
        /// Тип узла.
        /// </summary>
        public override semantic_node_type semantic_node_type
        {
            get
            {
                return semantic_node_type.namespace_constant_definition;
            }
        }

        /// <summary>
        /// Пространство имен в котором определена константа.
        /// Используется при обходе дерева посетителем.
        /// </summary>
        ICommonNamespaceNode INamespaceConstantDefinitionNode.comprehensive_namespace
        {
            get
            {
                return _comprehensive_namespace;
            }
        }
    }

    /// <summary>
    /// Класс, представляющий определение константы в классе.
    /// </summary>
    [Serializable]
    public class class_constant_definition : constant_definition_node, IClassConstantDefinitionNode
    {
        /// <summary>
        /// Тип, содержащий определение константы.
        /// </summary>
        private readonly common_type_node _comprehensive_type;

        private field_access_level _fal = field_access_level.fal_internal;

        public class_constant_definition(string name, location loc, common_type_node comprehensive_type, field_access_level field_access_level)
            :
            base(name, loc)
        {
            _comprehensive_type = comprehensive_type;
            _fal = field_access_level;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя константы.</param>
        /// <param name="cn">Значение константы.</param>
        /// <param name="loc">Расположение константы.</param>
        /// <param name="comprehensive_type">Тип, содержащий константу.</param>
        public class_constant_definition(string name, constant_node cn, location loc, common_type_node comprehensive_type, field_access_level field_access_level) :
            base(name,cn,loc)
        {
            _comprehensive_type = comprehensive_type;
            _fal = field_access_level;
        }

        /// <summary>
        /// Тип, содержащий константу.
        /// </summary>
        public common_type_node comperehensive_type
        {
            get
            {
                return _comprehensive_type;
            }
        }

        /// <summary>
        /// Тип узла.
        /// </summary>
        public override semantic_node_type semantic_node_type
        {
            get
            {
                return semantic_node_type.class_constant_definition;
            }
        }

        /// <summary>
        /// Метод для обхода дерева посетителем.
        /// </summary>
        /// <param name="visitor">Класс - посетитель дерева.</param>
        public override void visit(ISemanticVisitor visitor)
        {
            visitor.visit(this);
        }

        /// <summary>
        /// Тип, содержащий константу.
        /// Используется при обходе дерева посетителем.
        /// </summary>
        ITypeNode IClassMemberNode.comperehensive_type
        {
            get
            {
                return _comprehensive_type;
            }
        }

        public polymorphic_state polymorphic_state
        {
            get 
            {
                return polymorphic_state.ps_static;     
            }
        }

        public field_access_level field_access_level
        {
            get 
            { 
                return _fal; 
            }
        }
        ITypeNode IConstantDefinitionNode.type
        {
            get
            {
                return const_value.type;
            }
        }
    }

    /// <summary>
    /// Класс, представляющий определение константы в откомпилированном классе.
    /// </summary>
    [Serializable]
    public class compiled_class_constant_definition : constant_definition_node, ICompiledClassConstantDefinitionNode
    {
        /// <summary>
        /// Тип, содержащий определение константы.
        /// </summary>
        private readonly compiled_type_node _comprehensive_type;

        private System.Reflection.FieldInfo _fi; 

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public compiled_class_constant_definition(System.Reflection.FieldInfo fi, constant_node cn)
            : base(fi.Name, cn, null)
        {
            _comprehensive_type = compiled_type_node.get_type_node(fi.DeclaringType);
            _fi = fi;
        }
		
        public System.Reflection.FieldInfo field
        {
        	get
        	{
        		return _fi;
        	}
        }
        /// <summary>
        /// Тип, содержащий константу.
        /// </summary>
        ITypeNode IClassMemberNode.comperehensive_type
        {
            get
            {
                return _comprehensive_type;
            }
        }

        /// <summary>
        /// Тип узла.
        /// </summary>
        public override semantic_node_type semantic_node_type
        {
            get
            {
                return semantic_node_type.compiled_class_constant_definition;
            }
        }

        /// <summary>
        /// Метод для обхода дерева посетителем.
        /// </summary>
        /// <param name="visitor">Класс - посетитель дерева.</param>
        public override void visit(ISemanticVisitor visitor)
        {
            visitor.visit(this);
        }

        /// <summary>
        /// Тип, содержащий константу.
        /// Используется при обходе дерева посетителем.
        /// </summary>
        ICompiledTypeNode ICompiledClassConstantDefinitionNode.comprehensive_type
        {
            get
            {
                return _comprehensive_type;
            }
        }

        #region IClassMemberNode Members


        public polymorphic_state polymorphic_state
        {
            get 
            { 
                return polymorphic_state.ps_static; 
            }
        }

        public field_access_level field_access_level
        {
            get 
            {
                return NetHelper.GetFieldAccessLevel(_fi);
            }
        }

        #endregion
    }

    /// <summary>
    /// Класс, представляющий определение константы в классе.
    /// </summary>
    [Serializable]
    public class function_constant_definition : constant_definition_node, ICommonFunctionConstantDefinitionNode
    {
        /// <summary>
        /// Тип, содержащий определение константы.
        /// </summary>
        private readonly common_function_node _comprehensive_function;

        public function_constant_definition(string name, location loc, common_function_node comprehensive_function) :
            base(name, loc)
        {
            _comprehensive_function = comprehensive_function;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя константы.</param>
        /// <param name="cn">Значение константы.</param>
        /// <param name="loc">Расположение константы.</param>
        /// <param name="comprehensive_function">Функция, содержащая константу.</param>
        public function_constant_definition(string name, constant_node cn, location loc, common_function_node comprehensive_function) :
            base(name, cn, loc)
        {
            _comprehensive_function = comprehensive_function;
        }

        /// <summary>
        /// Функция, содержащая константу.
        /// </summary>
        public common_function_node comprehensive_function
        {
            get
            {
                return _comprehensive_function;
            }
        }

        /// <summary>
        /// Тип узла.
        /// </summary>
        public override semantic_node_type semantic_node_type
        {
            get
            {
                return semantic_node_type.function_constant_definition;
            }
        }

        /// <summary>
        /// Метод для обхода дерева посетителем.
        /// </summary>
        /// <param name="visitor">Класс - посетитель дерева.</param>
        public override void visit(ISemanticVisitor visitor)
        {
            visitor.visit(this);
        }

        /// <summary>
        /// Функция, в которой определена константа.
        /// Используется при обходе дерева посетителем.
        /// </summary>
        ICommonFunctionNode ICommonFunctionConstantDefinitionNode.comprehensive_function
        {
            get 
            {
                return _comprehensive_function;
            }
        }
    }
}
