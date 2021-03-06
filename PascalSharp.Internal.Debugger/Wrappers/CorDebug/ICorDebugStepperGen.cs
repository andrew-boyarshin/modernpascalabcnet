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
    public partial class ICorDebugStepper
	{
		
		private Interop.CorDebug.ICorDebugStepper wrappedObject;
		
		internal Interop.CorDebug.ICorDebugStepper WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugStepper(Interop.CorDebug.ICorDebugStepper wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(Wrappers.CorDebug.ICorDebugStepper));
		}
		
		public static Wrappers.CorDebug.ICorDebugStepper Wrap(Interop.CorDebug.ICorDebugStepper objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new Wrappers.CorDebug.ICorDebugStepper(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugStepper()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(Wrappers.CorDebug.ICorDebugStepper));
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
		
		public static bool operator ==(Wrappers.CorDebug.ICorDebugStepper o1, Wrappers.CorDebug.ICorDebugStepper o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(Wrappers.CorDebug.ICorDebugStepper o1, Wrappers.CorDebug.ICorDebugStepper o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			Wrappers.CorDebug.ICorDebugStepper casted = o as Wrappers.CorDebug.ICorDebugStepper;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public int IsActive
		{
			get
			{
				int pbActive;
				this.WrappedObject.IsActive(out pbActive);
				return pbActive;
			}
		}
		
		public void Deactivate()
		{
			this.WrappedObject.Deactivate();
		}
		
		public void SetInterceptMask(CorDebugIntercept mask)
		{
			this.WrappedObject.SetInterceptMask(((Interop.CorDebug.CorDebugIntercept)(mask)));
		}
		
		public void SetUnmappedStopMask(CorDebugUnmappedStop mask)
		{
			this.WrappedObject.SetUnmappedStopMask(((Interop.CorDebug.CorDebugUnmappedStop)(mask)));
		}
		
		public void Step(int bStepIn)
		{
			this.WrappedObject.Step(bStepIn);
		}
		
		public void StepRange(int bStepIn, System.IntPtr ranges, uint cRangeCount)
		{
			this.WrappedObject.StepRange(bStepIn, ranges, cRangeCount);
		}
		
		public void StepOut()
		{
			this.WrappedObject.StepOut();
		}
		
		public void SetRangeIL(int bIL)
		{
			this.WrappedObject.SetRangeIL(bIL);
		}
	}
}

#pragma warning restore 1591
