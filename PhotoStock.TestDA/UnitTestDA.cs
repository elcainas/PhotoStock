using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoStock.DataAccess;
using System.Linq;

namespace PhotoStock.TestDA
{
    [TestClass]
    public class UnitTestDA
    {
        private AlbumDA AlbumDA { get; set; }
        private PhotoDA PhotoDA { get; set; }
        public UnitTestDA()
        {
            AlbumDA = new AlbumDA();
            PhotoDA = new PhotoDA();
        }

        [TestMethod]
        public void TestGetAlbum()
        {
            var listaAlbum = AlbumDA.Get(1);
            Assert.IsNotNull(listaAlbum);
            Assert.AreNotEqual(listaAlbum.FirstOrDefault()?.Id, 0);
        }

        [TestMethod]
        public void TestGetPhotos()
        {
            var photos = PhotoDA.GetPhotoByAlbumId(1);
            Assert.IsNotNull(photos);
            Assert.AreNotEqual(photos.FirstOrDefault()?.Id, 0);
        }
    }
}
