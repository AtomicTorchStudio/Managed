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

public class ViewBase : Animatable {
  internal new static ViewBase CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ViewBase(cPtr, cMemoryOwn);
  }

  internal ViewBase(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ViewBase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ViewBase() {
  }

  public virtual void ClearItem(ListViewItem item) {
    NoesisGUI_PINVOKE.ViewBase_ClearItem(swigCPtr, ListViewItem.getCPtr(item));
  }

  public virtual void PrepareItem(ListViewItem item) {
    NoesisGUI_PINVOKE.ViewBase_PrepareItem(swigCPtr, ListViewItem.getCPtr(item));
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ViewBase_GetStaticType();
    return ret;
  }

}

}

