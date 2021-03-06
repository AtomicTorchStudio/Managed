//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class DataObjectCopyingEventArgs : DataObjectEventArgs {
  private HandleRef swigCPtr;

  internal DataObjectCopyingEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DataObjectCopyingEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DataObjectCopyingEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_DataObjectCopyingEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    DataObjectCopyingEventHandler handler_ = (DataObjectCopyingEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new DataObjectCopyingEventArgs(args, false));
    }
  }

  public IDataObject DataObject {
    get { return new DataObject(GetDataObjectHelper()); }
  }

  private object GetDataObjectHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.DataObjectCopyingEventArgs_GetDataObjectHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

}

}

