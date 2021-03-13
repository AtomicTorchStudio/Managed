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
using System.Collections.Generic;

namespace Noesis
{

public class ItemContainerGenerator : BaseComponent, Noesis.IRecyclingItemContainerGenerator {
  internal new static ItemContainerGenerator CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ItemContainerGenerator(cPtr, cMemoryOwn);
  }

  internal ItemContainerGenerator(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ItemContainerGenerator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ItemContainerGenerator() {
  }

  #region Events
  #region ItemsChanged
  public delegate void ItemsChangedHandler(object sender, ItemsChangedEventArgs e);
  public event ItemsChangedHandler ItemsChanged {
    add {
      if (!_ItemsChanged.ContainsKey(swigCPtr.Handle)) {
        _ItemsChanged.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_ItemContainerGenerator_ItemsChanged(_raiseItemsChanged, swigCPtr.Handle);
      }

      _ItemsChanged[swigCPtr.Handle] += value;
    }
    remove {
      if (_ItemsChanged.ContainsKey(swigCPtr.Handle)) {

        _ItemsChanged[swigCPtr.Handle] -= value;

        if (_ItemsChanged[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_ItemContainerGenerator_ItemsChanged(_raiseItemsChanged, swigCPtr.Handle);

          _ItemsChanged.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaiseItemsChangedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseItemsChangedCallback _raiseItemsChanged = RaiseItemsChanged;

  [MonoPInvokeCallback(typeof(RaiseItemsChangedCallback))]
  private static void RaiseItemsChanged(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _ItemsChanged.Remove(cPtr);
          return;
        }
        ItemsChangedHandler handler = null;
        if (!_ItemsChanged.TryGetValue(cPtr, out handler)) {
          throw new System.InvalidOperationException("Delegate not registered for ItemsChanged event");
        }
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new ItemsChangedEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<IntPtr, ItemsChangedHandler> _ItemsChanged =
      new Dictionary<IntPtr, ItemsChangedHandler>();
  #endregion

  #region StatusChanged
  public delegate void StatusChangedHandler(object sender, NoesisEventArgs e);
  public event StatusChangedHandler StatusChanged {
    add {
      if (!_StatusChanged.ContainsKey(swigCPtr.Handle)) {
        _StatusChanged.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_ItemContainerGenerator_StatusChanged(_raiseStatusChanged, swigCPtr.Handle);
      }

      _StatusChanged[swigCPtr.Handle] += value;
    }
    remove {
      if (_StatusChanged.ContainsKey(swigCPtr.Handle)) {

        _StatusChanged[swigCPtr.Handle] -= value;

        if (_StatusChanged[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_ItemContainerGenerator_StatusChanged(_raiseStatusChanged, swigCPtr.Handle);

          _StatusChanged.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaiseStatusChangedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseStatusChangedCallback _raiseStatusChanged = RaiseStatusChanged;

  [MonoPInvokeCallback(typeof(RaiseStatusChangedCallback))]
  private static void RaiseStatusChanged(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _StatusChanged.Remove(cPtr);
          return;
        }
        StatusChangedHandler handler = null;
        if (!_StatusChanged.TryGetValue(cPtr, out handler)) {
          throw new System.InvalidOperationException("Delegate not registered for StatusChanged event");
        }
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new NoesisEventArgs());// new NoesisEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<IntPtr, StatusChangedHandler> _StatusChanged =
      new Dictionary<IntPtr, StatusChangedHandler>();
  #endregion

  #endregion

  ItemContainerGenerator IItemContainerGenerator.GetItemContainerGeneratorForPanel(Panel panel) {
    if (!panel.IsItemsHost) {
      throw new ArgumentException("Panel is not an ItemsHost");
    }
    return GetItemContainerGeneratorForPanelHelper(panel);
  }

  IDisposable IItemContainerGenerator.StartAt(GeneratorPosition position, GeneratorDirection direction) {
    return ((IItemContainerGenerator)this).StartAt(position, direction, false);
  }

  IDisposable IItemContainerGenerator.StartAt(GeneratorPosition position, GeneratorDirection direction, bool allowStartAtRealizedItem) {
    if (Status == GeneratorStatus.GeneratingContainers) {
        throw new InvalidOperationException("Generation already in progress");
    }
    StartAtHelper(position, direction, allowStartAtRealizedItem);
    return new Generator(this);
  }

  DependencyObject IItemContainerGenerator.GenerateNext() {
    if (Status != GeneratorStatus.GeneratingContainers) {
        throw new InvalidOperationException("Generation is not in progress");
    }
    IntPtr cPtr = GenerateNextHelper();
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, true);
  }

  DependencyObject IItemContainerGenerator.GenerateNext(out bool isNewlyRealized) {
    if (Status != GeneratorStatus.GeneratingContainers) {
        throw new InvalidOperationException("Generation is not in progress");
    }
    isNewlyRealized = false;
    IntPtr cPtr = GenerateNextRealizedHelper(ref isNewlyRealized);
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, true);
  }

  void IItemContainerGenerator.PrepareItemContainer(DependencyObject container) {
    PrepareItemContainerHelper(container);
  }

  void IItemContainerGenerator.RemoveAll() {
    RemoveAllHelper();
  }

  void IItemContainerGenerator.Remove(GeneratorPosition position, int count) {
    if (position.Offset != 0) {
      throw new ArgumentException("Remove requires a position with offset zero");
    }
    if (count <= 0) {
      throw new ArgumentException("Remove requires a position with positive count");
    }
    int index = ((IItemContainerGenerator)this).IndexFromGeneratorPosition(position);
    if (index < 0) {
      throw new IndexOutOfRangeException("position");
    }
    int numItems = ((IItemContainerGenerator)this).IndexFromGeneratorPosition(new GeneratorPosition(-1, -1)) + 1;
    if (index >= numItems) {
      throw new IndexOutOfRangeException("position");
    }
    RemoveHelper(position, count);
  }

  GeneratorPosition IItemContainerGenerator.GeneratorPositionFromIndex(int itemIndex) {
    GeneratorPosition position = new GeneratorPosition();
    GeneratorPositionFromIndexHelper(itemIndex, ref position);
    return position;
  }

  int IItemContainerGenerator.IndexFromGeneratorPosition(GeneratorPosition position) {
    return IndexFromGeneratorPositionHelper(position);
  }

  void IRecyclingItemContainerGenerator.Recycle(GeneratorPosition position, int count) {
    if (position.Offset != 0) {
      throw new ArgumentException("Remove requires a position with offset zero");
    }
    if (count <= 0) {
      throw new ArgumentException("Remove requires a position with positive count");
    }
    int index = ((IItemContainerGenerator)this).IndexFromGeneratorPosition(position);
    if (index < 0) {
      throw new IndexOutOfRangeException("position");
    }
    int numItems = ((IItemContainerGenerator)this).IndexFromGeneratorPosition(new GeneratorPosition(-1, -1)) + 1;
    if (index >= numItems) {
      throw new IndexOutOfRangeException("position");
    }
    RecycleHelper(position, count);
  }

  private struct Generator: IDisposable {

    internal Generator(ItemContainerGenerator generator) {
      _generator = generator;
    }

    void IDisposable.Dispose() {
      if (_generator != null) {
        _generator.StopHelper();
        _generator = null;
      }
      GC.SuppressFinalize(this);
    }

    ItemContainerGenerator _generator;
  }

  public DependencyObject ContainerFromIndex(int index) {
    IntPtr cPtr = NoesisGUI_PINVOKE.ItemContainerGenerator_ContainerFromIndex(swigCPtr, index);
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  public DependencyObject ContainerFromItem(object item) {
    IntPtr cPtr = NoesisGUI_PINVOKE.ItemContainerGenerator_ContainerFromItem(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  public int IndexFromContainer(DependencyObject container) {
    int ret = NoesisGUI_PINVOKE.ItemContainerGenerator_IndexFromContainer(swigCPtr, DependencyObject.getCPtr(container));
    return ret;
  }

  public object ItemFromContainer(DependencyObject container) {
    IntPtr cPtr = NoesisGUI_PINVOKE.ItemContainerGenerator_ItemFromContainer(swigCPtr, DependencyObject.getCPtr(container));
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  public void StartBatch() {
    NoesisGUI_PINVOKE.ItemContainerGenerator_StartBatch(swigCPtr);
  }

  public void StopBatch() {
    NoesisGUI_PINVOKE.ItemContainerGenerator_StopBatch(swigCPtr);
  }

  public GeneratorStatus Status {
    get {
      GeneratorStatus ret = (GeneratorStatus)NoesisGUI_PINVOKE.ItemContainerGenerator_Status_get(swigCPtr);
      return ret;
    } 
  }

  private ItemContainerGenerator GetItemContainerGeneratorForPanelHelper(Panel panel) {
    IntPtr cPtr = NoesisGUI_PINVOKE.ItemContainerGenerator_GetItemContainerGeneratorForPanelHelper(swigCPtr, Panel.getCPtr(panel));
    ItemContainerGenerator ret = (cPtr == IntPtr.Zero) ? null : new ItemContainerGenerator(cPtr, false);
    return ret;
  }

  private void GeneratorPositionFromIndexHelper(int itemIndex, ref GeneratorPosition position) {
    NoesisGUI_PINVOKE.ItemContainerGenerator_GeneratorPositionFromIndexHelper(swigCPtr, itemIndex, ref position);
  }

  private int IndexFromGeneratorPositionHelper(GeneratorPosition position) {
    int ret = NoesisGUI_PINVOKE.ItemContainerGenerator_IndexFromGeneratorPositionHelper(swigCPtr, ref position);
    return ret;
  }

  private void StartAtHelper(GeneratorPosition position, GeneratorDirection direction, bool allowStartAtRealizedItem) {
    NoesisGUI_PINVOKE.ItemContainerGenerator_StartAtHelper(swigCPtr, ref position, (int)direction, allowStartAtRealizedItem);
  }

  private IntPtr GenerateNextHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.ItemContainerGenerator_GenerateNextHelper(swigCPtr);
    return ret;
  }

  private IntPtr GenerateNextRealizedHelper(ref bool isNewlyRealized) {
    IntPtr ret = NoesisGUI_PINVOKE.ItemContainerGenerator_GenerateNextRealizedHelper(swigCPtr, ref isNewlyRealized);
    return ret;
  }

  private void StopHelper() {
    NoesisGUI_PINVOKE.ItemContainerGenerator_StopHelper(swigCPtr);
  }

  private void PrepareItemContainerHelper(DependencyObject container) {
    NoesisGUI_PINVOKE.ItemContainerGenerator_PrepareItemContainerHelper(swigCPtr, DependencyObject.getCPtr(container));
  }

  private void RemoveAllHelper() {
    NoesisGUI_PINVOKE.ItemContainerGenerator_RemoveAllHelper(swigCPtr);
  }

  private void RemoveHelper(GeneratorPosition position, int count) {
    NoesisGUI_PINVOKE.ItemContainerGenerator_RemoveHelper(swigCPtr, ref position, count);
  }

  private void RecycleHelper(GeneratorPosition position, int count) {
    NoesisGUI_PINVOKE.ItemContainerGenerator_RecycleHelper(swigCPtr, ref position, count);
  }

}

}

