// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

using System;

#pragma warning disable 1591

namespace PascalSharp.Internal.Debugger.Wrappers.CorDebug
{
    public partial class ICorDebugHandleValue
	{
		
		private Interop.CorDebug.ICorDebugHandleValue wrappedObject;
		
		internal Interop.CorDebug.ICorDebugHandleValue WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugHandleValue(Interop.CorDebug.ICorDebugHandleValue wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugHandleValue));
		}
		
		public static ICorDebugHandleValue Wrap(Interop.CorDebug.ICorDebugHandleValue objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugHandleValue(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugHandleValue()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugHandleValue));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugHandleValue o1, ICorDebugHandleValue o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugHandleValue o1, ICorDebugHandleValue o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugHandleValue casted = o as ICorDebugHandleValue;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public uint Type
		{
			get
			{
				uint pType;
				this.WrappedObject.GetType(out pType);
				return pType;
			}
		}
		
		public uint Size
		{
			get
			{
				uint pSize;
				this.WrappedObject.GetSize(out pSize);
				return pSize;
			}
		}
		
		public ulong Address
		{
			get
			{
				ulong pAddress;
				this.WrappedObject.GetAddress(out pAddress);
				return pAddress;
			}
		}
		
		public ICorDebugValueBreakpoint CreateBreakpoint()
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			Interop.CorDebug.ICorDebugValueBreakpoint out_ppBreakpoint;
			this.WrappedObject.CreateBreakpoint(out out_ppBreakpoint);
			ppBreakpoint = ICorDebugValueBreakpoint.Wrap(out_ppBreakpoint);
			return ppBreakpoint;
		}
		
		public int IsNull
		{
			get
			{
				int pbNull;
				this.WrappedObject.IsNull(out pbNull);
				return pbNull;
			}
		}
		
		public ulong Value
		{
			get
			{
				ulong pValue;
				this.WrappedObject.GetValue(out pValue);
				return pValue;
			}
		}
		
		public void SetValue(ulong value)
		{
			this.WrappedObject.SetValue(value);
		}
		
		public ICorDebugValue Dereference()
		{
			ICorDebugValue ppValue;
			Interop.CorDebug.ICorDebugValue out_ppValue;
			this.WrappedObject.Dereference(out out_ppValue);
			ppValue = ICorDebugValue.Wrap(out_ppValue);
			return ppValue;
		}
		
		public ICorDebugValue DereferenceStrong()
		{
			ICorDebugValue ppValue;
			Interop.CorDebug.ICorDebugValue out_ppValue;
			this.WrappedObject.DereferenceStrong(out out_ppValue);
			ppValue = ICorDebugValue.Wrap(out_ppValue);
			return ppValue;
		}
		
		public CorDebugHandleType HandleType
		{
			get
			{
				CorDebugHandleType pType;
				Interop.CorDebug.CorDebugHandleType out_pType;
				this.WrappedObject.GetHandleType(out out_pType);
				pType = ((CorDebugHandleType)(out_pType));
				return pType;
			}
		}
		
		public void Dispose()
		{
			this.WrappedObject.Dispose();
		}
	}
}

#pragma warning restore 1591