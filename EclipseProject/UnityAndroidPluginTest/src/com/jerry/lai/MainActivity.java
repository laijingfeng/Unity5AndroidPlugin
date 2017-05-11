package com.jerry.lai;

import android.os.Bundle;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		JerryHelper.log("MainActivity onCreate");
		super.onCreate(savedInstanceState);
	}

	public int GetInt() {
		JerryHelper.log("MainActivity GetInt");
		return 1000;
	}

	public void GiveMeAMsg() {
		JerryHelper.log("MainActivity GiveMeAMsg");
		UnityPlayer.UnitySendMessage("Main Camera", "FuncA", "hello");
	}
}