﻿namespace Project4.Modify
{
    public class TaiKhoanModel
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
