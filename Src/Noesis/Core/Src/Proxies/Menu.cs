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

internal class Menu : MenuBase {
  internal new static Menu CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Menu(cPtr, cMemoryOwn);
  }

  internal Menu(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Menu obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Menu() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type == typeof(Menu)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Menu();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsMainMenuProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Menu_IsMainMenuProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsMainMenu {
    set {
      NoesisGUI_PINVOKE.Menu_IsMainMenu_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Menu_IsMainMenu_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Menu_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Menu(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

