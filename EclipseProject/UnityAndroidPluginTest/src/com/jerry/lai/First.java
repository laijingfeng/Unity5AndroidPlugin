package com.jerry.lai;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

public class First extends Activity {
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		JerryHelper.log("First onCreate");
		Intent intent = new Intent(this, MainActivity.class);
		this.startActivity(intent);
	}
}