/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using System.Collections;

public class OcclusionAppManager : AppManager 
{
    public OcclusionManagementEventHandler mHandler;
    
    public override void InitManager ()
    {
        base.InitManager ();
        mHandler.InitHandler();
    }
    
    public override void Draw ()
    {
        base.Draw ();
    }
    
    public override void UpdateManager ()
    {
        base.UpdateManager ();
    }
}
