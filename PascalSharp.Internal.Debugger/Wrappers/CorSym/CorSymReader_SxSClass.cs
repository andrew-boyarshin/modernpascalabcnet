// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

using System;

#pragma warning disable 1591

namespace PascalSharp.Internal.Debugger.Wrappers.CorSym
{
    public partial class CorSymReader_SxSClass
	{
		
		private Interop.CorSym.CorSymReader_SxSClass wrappedObject;
		
		internal Interop.CorSym.CorSymReader_SxSClass WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public CorSymReader_SxSClass(Interop.CorSym.CorSymReader_SxSClass wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(CorSymReader_SxSClass));
		}
		
		public static CorSymReader_SxSClass Wrap(Interop.CorSym.CorSymReader_SxSClass objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new CorSymReader_SxSClass(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~CorSymReader_SxSClass()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(CorSymReader_SxSClass));
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
		
		public static bool operator ==(CorSymReader_SxSClass o1, CorSymReader_SxSClass o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(CorSymReader_SxSClass o1, CorSymReader_SxSClass o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			CorSymReader_SxSClass casted = o as CorSymReader_SxSClass;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public CorSym.ISymUnmanagedDocument GetDocument(System.IntPtr url, System.Guid language, System.Guid languageVendor, System.Guid documentType)
		{
			return ISymUnmanagedDocument.Wrap(this.WrappedObject.GetDocument(url, language, languageVendor, documentType));
		}
		
		public void GetDocuments(uint cDocs, out uint pcDocs, System.IntPtr pDocs)
		{
			this.WrappedObject.GetDocuments(cDocs, out pcDocs, pDocs);
		}
		
		public int GetDocumentVersion(CorSym.ISymUnmanagedDocument pDoc, out int version)
		{
			int pbCurrent;
			this.WrappedObject.GetDocumentVersion(pDoc.WrappedObject, out version, out pbCurrent);
			return pbCurrent;
		}
		
		public void GetGlobalVariables(uint cVars, out uint pcVars, System.IntPtr pVars)
		{
			this.WrappedObject.GetGlobalVariables(cVars, out pcVars, pVars);
		}
		
		public CorSym.ISymUnmanagedMethod GetMethod(uint token)
		{
			return ISymUnmanagedMethod.Wrap(this.WrappedObject.GetMethod(token));
		}
		
		public CorSym.ISymUnmanagedMethod GetMethodByVersion(uint token, int version)
		{
			return ISymUnmanagedMethod.Wrap(this.WrappedObject.GetMethodByVersion(token, version));
		}
		
		public CorSym.ISymUnmanagedMethod GetMethodFromDocumentPosition(CorSym.ISymUnmanagedDocument document, uint line, uint column)
		{
			return ISymUnmanagedMethod.Wrap(this.WrappedObject.GetMethodFromDocumentPosition(document.WrappedObject, line, column));
		}
		
		public void GetMethodsFromDocumentPosition(CorSym.ISymUnmanagedDocument document, uint line, uint column, uint cMethod, out uint pcMethod, System.IntPtr pRetVal)
		{
			this.WrappedObject.GetMethodsFromDocumentPosition(document.WrappedObject, line, column, cMethod, out pcMethod, pRetVal);
		}
		
		public int GetMethodVersion(CorSym.ISymUnmanagedMethod pMethod)
		{
			int version;
			this.WrappedObject.GetMethodVersion(pMethod.WrappedObject, out version);
			return version;
		}
		
		public void GetNamespaces(uint cNameSpaces, out uint pcNameSpaces, System.IntPtr namespaces)
		{
			this.WrappedObject.GetNamespaces(cNameSpaces, out pcNameSpaces, namespaces);
		}
		
		public void GetSymAttribute(uint parent, System.IntPtr name, uint cBuffer, out uint pcBuffer, System.IntPtr buffer)
		{
			this.WrappedObject.GetSymAttribute(parent, name, cBuffer, out pcBuffer, buffer);
		}
		
		public void GetSymbolStoreFileName(uint cchName, out uint pcchName, System.IntPtr szName)
		{
			this.WrappedObject.GetSymbolStoreFileName(cchName, out pcchName, szName);
		}
		
		public uint UserEntryPoint
		{
			get
			{
				return this.WrappedObject.GetUserEntryPoint();
			}
		}
		
		public void GetVariables(uint parent, uint cVars, out uint pcVars, System.IntPtr pVars)
		{
			this.WrappedObject.GetVariables(parent, cVars, out pcVars, pVars);
		}
		
		public void Initialize(object importer, System.IntPtr filename, System.IntPtr searchPath, IStream pIStream)
		{
			this.WrappedObject.Initialize(importer, filename, searchPath, pIStream.WrappedObject);
		}
		
		public void ReplaceSymbolStore(System.IntPtr filename, IStream pIStream)
		{
			this.WrappedObject.ReplaceSymbolStore(filename, pIStream.WrappedObject);
		}
		
		public void UpdateSymbolStore(System.IntPtr filename, IStream pIStream)
		{
			this.WrappedObject.UpdateSymbolStore(filename, pIStream.WrappedObject);
		}
	}
}

#pragma warning restore 1591