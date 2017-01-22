using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using Custom_RecyclerView.mData;
using Custom_RecyclerView.mRecycler;


namespace Custom_RecyclerView
{
    [Activity(Label = "Custom_RecyclerView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private RecyclerView rv;
        private MyAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            //RV
            rv = FindViewById<RecyclerView>(Resource.Id.mRecylcerID);
            rv.SetLayoutManager(new LinearLayoutManager(this));
            rv.SetItemAnimator(new DefaultItemAnimator());

            //ADAPTER
            adapter=new MyAdapter(TVShowsCollection.getTVShows());
            rv.SetAdapter(adapter);

            adapter.ItemClick += onItemClick;
        }

        void onItemClick(object sender, int position)
        {
            Toast.MakeText(this,TVShowsCollection.getTVShows()[position].Name,ToastLength.Short).Show();
        }

    }
}

