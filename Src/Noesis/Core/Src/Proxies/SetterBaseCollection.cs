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

public class SetterBaseCollection : UICollection<SetterBase> {
  internal new static SetterBaseCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new SetterBaseCollection(cPtr, cMemoryOwn);
  }

  internal SetterBaseCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(SetterBaseCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.SetterBaseCollection_GetStaticType();
    return ret;
  }

  public SetterBaseCollection() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_SetterBaseCollection();
  }

}

}

