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

public class UserControl : ContentControl {
  internal new static UserControl CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new UserControl(cPtr, cMemoryOwn);
  }

  internal UserControl(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(UserControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.UserControl_GetStaticType();
    return ret;
  }

  public UserControl() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type == typeof(UserControl)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_UserControl();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_UserControl(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

