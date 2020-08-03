package com.gorugoru.unityplugin

import android.os.Bundle
import android.util.Log
import com.unity3d.player.UnityPlayerActivity

class unityplugin : UnityPlayerActivity() {

    override fun onCreate(saveInstanceState : Bundle?){

        super.onCreate(saveInstanceState)

        Log.d("UnityLogTest","oncreate")

    }

}