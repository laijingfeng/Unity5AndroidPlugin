package com.jerry.lai;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

public class First extends Activity {
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		JerryHelper.jerryLog("First onCreate");
		Intent intent = new Intent(this, MainActivity.class);
		this.startActivity(intent);
	}
}
