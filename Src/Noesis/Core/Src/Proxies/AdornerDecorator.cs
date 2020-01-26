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

public class AdornerDecorator : Decorator {
  internal new static AdornerDecorator CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new AdornerDecorator(cPtr, cMemoryOwn);
  }

  internal AdornerDecorator(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(AdornerDecorator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public AdornerDecorator(bool logicalChild) : this(NoesisGUI_PINVOKE.new_AdornerDecorator__SWIG_0(logicalChild), true) {
  }

  public AdornerDecorator() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_AdornerDecorator__SWIG_1();
  }

  public void AddLayer(Visual layerRoot) {
    NoesisGUI_PINVOKE.AdornerDecorator_AddLayer(swigCPtr, Visual.getCPtr(layerRoot));
  }

  public void RemoveLayer(Visual layerRoot) {
    NoesisGUI_PINVOKE.AdornerDecorator_RemoveLayer(swigCPtr, Visual.getCPtr(layerRoot));
  }

}

}

