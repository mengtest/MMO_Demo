﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FuncsMgr : BaseMgr
{
    [SerializeField]
    string Filter_Circle = "circle";
    [SerializeField]
    string Func_AttackPhy = "phyattack";

    private Dictionary<string, AbsFilter> mFilterList = new Dictionary<string, AbsFilter>();
    private Dictionary<string, AbsFunc> mFuncList = new Dictionary<string, AbsFunc>();

    public override void Awake()
    {
        base.Awake();
        InitFiltersAndFuncs();
    }

    /// <summary>
    /// 初始化各种模板
    /// </summary>
    public void InitFiltersAndFuncs()
    {
        #region RegisterFilter
        RegisterFilter(SphereFilter.CreateFilter(Filter_Circle));
        #endregion

        #region RegisterFunction
        RegisterFunction(AttackPhy.CreateFunc(Func_AttackPhy));
        #endregion
    }

    /// <summary>
    /// 注册Function
    /// </summary>
    /// <param name="_object"></param>
    public void RegisterFunction(AbsFunc _abs)
    {
        string key = _abs.Key;
        if (!mFuncList.ContainsKey(key))
            mFuncList.Add(key, _abs);
    }

    /// <summary>
    /// 注册选人
    /// </summary>
    /// <param name="_abs"></param>
    public void RegisterFilter(AbsFilter _abs)
    {
        string key = _abs.Key;
        if (!mFilterList.ContainsKey(key))
            mFilterList.Add(key, _abs);
    }

    public AbsFilter CreateFilter(string _str)
    {
        string str = _str.ToLower();

        return null;
    }

    public AbsFunc CreateFunction(string _str)
    {

        return null;
    }
}
