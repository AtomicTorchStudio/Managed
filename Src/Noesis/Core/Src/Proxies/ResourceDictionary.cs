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
using System.Collections;
using System.Collections.Generic;

namespace Noesis
{

public class ResourceDictionary : BaseDictionary, IDictionary {
  internal new static ResourceDictionary CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ResourceDictionary(cPtr, cMemoryOwn);
  }

  internal ResourceDictionary(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ResourceDictionary obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public object this[object key] {
    get {
      if (key == null) {
        throw new ArgumentNullException("key");
      }
      IntPtr cPtr = GetValueHelper(GetValidKey(key));
      return Noesis.Extend.GetProxy(cPtr, true);
    }
    set {
      if (key == null) {
        throw new ArgumentNullException("key");
      }
      if (value == null) {
        throw new ArgumentNullException("value");
      }
      SetValueHelper(GetValidKey(key), value);
    }
  }

  public ICollection Keys {
    get {
      KeysData keys = new KeysData { Keys = new object[Count], Index = 0 };
      int id = keys.GetHashCode();
      _keysData[id] = keys;
      ResourceDictionary_EnumKeys(ResourceDictionary.getCPtr(this), id, _enumKeys);
      _keysData.Remove(id);
      return keys.Keys;
    }
  }

  public ICollection Values {
    get {
      return new ValuesCollection(this);
    }
  }

  public bool Contains(object key) {
    return ContainsHelper(GetValidKey(key));
  }

  public void Add(object key, object value) {
    AddHelper(GetValidKey(key), value);
  }

  public void Remove(object key) {
    RemoveHelper(GetValidKey(key));
  }

  public Enumerator GetEnumerator() {
    return new Enumerator(this);
  }

  IDictionaryEnumerator IDictionary.GetEnumerator() {
    return new Enumerator(this);
  }

  IEnumerator IEnumerable.GetEnumerator() {
    return new Enumerator(this);
  }

  #region Key validation
  private string GetValidKey(object key) {
    if (key is string) {
      return (string)key;
    }
    if (key is Type) {
      return ((Type)key).FullName;
    }
    throw new ArgumentException("Only string and Type keys are supported");
  }
  #endregion

  #region Enumeration

  public class Enumerator : IDictionaryEnumerator {
    internal Enumerator(ResourceDictionary owner) {
      _owner = owner;
      _keysEnumerator = _owner.Keys.GetEnumerator();
    }

    #region IEnumerator
    object IEnumerator.Current {
      get {
        return ((IDictionaryEnumerator)this).Entry;
      }
    }

    bool IEnumerator.MoveNext() {
      return _keysEnumerator.MoveNext();
    }

    void IEnumerator.Reset() {
      _keysEnumerator.Reset();
    }
    #endregion

    #region IDictionaryEnumerator
    DictionaryEntry IDictionaryEnumerator.Entry {
      get {
        object key = _keysEnumerator.Current;
        object value = _owner[key];
        return new DictionaryEntry(key, value);
      }
    }

    object IDictionaryEnumerator.Key {
      get {
        return _keysEnumerator.Current;
      }
    }

    object IDictionaryEnumerator.Value {
      get {
        return _owner[_keysEnumerator.Current];
      }
    }
    #endregion
 
    #region Data
    private ResourceDictionary _owner;
    private IEnumerator _keysEnumerator;
    #endregion
  }

  #region Keys
  [DllImport(Library.Name)]
  private static extern void ResourceDictionary_EnumKeys(HandleRef dictionary, int id, ResourceDictionaryEnumKeysCallback callback);

  private class KeysData {
    public object[] Keys;
    public int Index;
  }

  private delegate void ResourceDictionaryEnumKeysCallback(int id, string key);
  private static ResourceDictionaryEnumKeysCallback _enumKeys = OnEnumKeys;
  [MonoPInvokeCallback(typeof(ResourceDictionaryEnumKeysCallback))]
  private static void OnEnumKeys(int id, string key) {
    try {
      if (Noesis.Extend.Initialized) {
        KeysData keys = _keysData[id];
        Type type = Noesis.Extend.FindType(key);
        keys.Keys[keys.Index++] = type != null ? (object)type : (object)key;
      }
    }
    catch (Exception e) {
      Error.UnhandledException(e);
    }
  }

  private static Dictionary<int, KeysData> _keysData =
   new Dictionary<int, KeysData>();
  #endregion

  #region Values
  private class ValuesCollection : ICollection {
    internal ValuesCollection(ResourceDictionary owner) {
      _owner = owner;
    }

    #region ICollection
    int ICollection.Count {
      get {
        return _owner.Count;
      }
    }

    bool ICollection.IsSynchronized {
      get {
        return false;
      }
    }

    object ICollection.SyncRoot {
      get {
        return this;
      }
    }

    void ICollection.CopyTo(Array array, int index) {
      foreach (object key in _owner.Keys) {
        array.SetValue(_owner[key], index++);
      }
    }

    public Enumerator GetEnumerator() {
      return new Enumerator(_owner);
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return new Enumerator(_owner);
    }

    public class Enumerator : IEnumerator {
      internal Enumerator(ResourceDictionary owner) {
        _owner = owner;
        _keysEnumerator = _owner.Keys.GetEnumerator();
      }
  
      #region IEnumerator
      object IEnumerator.Current {
        get {
          return _owner[_keysEnumerator.Current];
        }
      }
  
      bool IEnumerator.MoveNext() {
        return _keysEnumerator.MoveNext();
      }
  
      void IEnumerator.Reset() {
        _keysEnumerator.Reset();
      }
      #endregion
  
      #region Data
      private ResourceDictionary _owner;
      private IEnumerator _keysEnumerator;
      #endregion
    }
    #endregion
 
    #region Data
    private ResourceDictionary _owner;
    #endregion
  }
  #endregion

  #endregion

  public void CopyTo(DictionaryEntry[] array, int index) {
    ICollection keys = Keys;
    int i = index;
    foreach (object key in keys) {
      array[i++] = new DictionaryEntry(key, this[key]);
    }
  }

  void ICollection.CopyTo(Array array, int index) {
    CopyTo(array as DictionaryEntry[], index);
  }

  object ICollection.SyncRoot {
    get {
      return this;
    }
  }

  public bool IsFixedSize {
    get { return false; }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public ResourceDictionary() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(ResourceDictionary)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ResourceDictionary();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public void Clear() {
    NoesisGUI_PINVOKE.ResourceDictionary_Clear(swigCPtr);
  }

  public ResourceDictionaryCollection MergedDictionaries {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ResourceDictionary_MergedDictionaries_get(swigCPtr);
      return (ResourceDictionaryCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Uri Source {
    set {
      NoesisGUI_PINVOKE.ResourceDictionary_Source_set(swigCPtr, value != null ? UriHelper.GetPath(value) : string.Empty);
    }
    get {
      IntPtr uriPtr = NoesisGUI_PINVOKE.ResourceDictionary_Source_get(swigCPtr);
      string uri = Noesis.Extend.StringFromNativeUtf8(uriPtr);
      return new Uri(uri, UriKind.Relative);
    }
  }

  public int Count {
    get {
      int ret = NoesisGUI_PINVOKE.ResourceDictionary_Count_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsReadOnly {
    get {
      bool ret = NoesisGUI_PINVOKE.ResourceDictionary_IsReadOnly_get(swigCPtr);
      return ret;
    } 
  }

  private IntPtr GetValueHelper(string key) {
    IntPtr ret = NoesisGUI_PINVOKE.ResourceDictionary_GetValueHelper(swigCPtr, key != null ? key : string.Empty);
    return ret;
  }

  private void SetValueHelper(string key, object value) {
    NoesisGUI_PINVOKE.ResourceDictionary_SetValueHelper(swigCPtr, key != null ? key : string.Empty, Noesis.Extend.GetInstanceHandle(value));
  }

  private bool ContainsHelper(string key) {
    bool ret = NoesisGUI_PINVOKE.ResourceDictionary_ContainsHelper(swigCPtr, key != null ? key : string.Empty);
    return ret;
  }

  private void AddHelper(string key, object value) {
    NoesisGUI_PINVOKE.ResourceDictionary_AddHelper(swigCPtr, key != null ? key : string.Empty, Noesis.Extend.GetInstanceHandle(value));
  }

  private void RemoveHelper(string key) {
    NoesisGUI_PINVOKE.ResourceDictionary_RemoveHelper(swigCPtr, key != null ? key : string.Empty);
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ResourceDictionary(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

