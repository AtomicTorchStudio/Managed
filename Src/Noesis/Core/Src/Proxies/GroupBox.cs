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

public class GroupBox : HeaderedContentControl {
  internal new static GroupBox CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GroupBox(cPtr, cMemoryOwn);
  }

  internal GroupBox(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GroupBox obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public GroupBox() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(GroupBox)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_GroupBox();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_GroupBox(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

