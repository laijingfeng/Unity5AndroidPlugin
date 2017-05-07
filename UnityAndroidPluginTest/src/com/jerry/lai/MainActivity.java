package com.jerry.lai;

import android.os.Bundle;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
	}

	public int GetInt() {
		return 1000;
	}

	public void GiveMeAMsg() {
		UnityPlayer.UnitySendMessage("Main Camera", "FuncA", "hello");
	}
}