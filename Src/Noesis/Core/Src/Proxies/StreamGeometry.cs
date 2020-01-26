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

public class StreamGeometry : Geometry {
  internal new static StreamGeometry CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new StreamGeometry(cPtr, cMemoryOwn);
  }

  internal StreamGeometry(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(StreamGeometry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override string ToString() {
    return ToStringHelper();
  }

  public StreamGeometry(string data) : this(NoesisGUI_PINVOKE.new_StreamGeometry__SWIG_0(data != null ? data : string.Empty), true) {
  }

  public StreamGeometry() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_StreamGeometry__SWIG_1();
  }

  public void SetData(string data) {
    NoesisGUI_PINVOKE.StreamGeometry_SetData(swigCPtr, data != null ? data : string.Empty);
  }

  public StreamGeometryContext Open() {
    StreamGeometryContext ret = new StreamGeometryContext(NoesisGUI_PINVOKE.StreamGeometry_Open(swigCPtr), true);
    return ret;
  }

  public override bool IsEmpty() {
    bool ret = NoesisGUI_PINVOKE.StreamGeometry_IsEmpty(swigCPtr);
    return ret;
  }

  public static DependencyProperty FillRuleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.StreamGeometry_FillRuleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FillRule FillRule {
    set {
      NoesisGUI_PINVOKE.StreamGeometry_FillRule_set(swigCPtr, (int)value);
    } 
    get {
      FillRule ret = (FillRule)NoesisGUI_PINVOKE.StreamGeometry_FillRule_get(swigCPtr);
      return ret;
    } 
  }

  private string ToStringHelper() {
    IntPtr strPtr = NoesisGUI_PINVOKE.StreamGeometry_ToStringHelper(swigCPtr);
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    NoesisGUI_PINVOKE.FreeString(strPtr);
    return str;
  }

}

}

