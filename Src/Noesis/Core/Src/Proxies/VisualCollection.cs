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

public class VisualCollection : UICollection<Visual> {
  internal new static VisualCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new VisualCollection(cPtr, cMemoryOwn);
  }

  internal VisualCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(VisualCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected VisualCollection() {
  }

  public VisualCollection(Visual parent) : this(Create(CheckParent(parent)), true) {
  }

  private static Visual CheckParent(Visual parent) {
    if (parent == null) {
      throw new ArgumentNullException("parent");
    }
    return parent;
  }

  private static IntPtr Create(Visual parent) {
    IntPtr ret = NoesisGUI_PINVOKE.VisualCollection_Create(Visual.getCPtr(parent));
    return ret;
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.VisualCollection_GetStaticType();
    return ret;
  }

}

}

