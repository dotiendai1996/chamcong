﻿using Abp.Application.Services.Dto;
using System;

namespace Hinnova.QLNSDtos
{

    public class GetAllHoSosInput : PagedAndSortedResultRequestDto
	{
		public string Filter { get; set; }

		public string TenCtyFilter { get; set; }

		public string HopDongHienTaiFilter { get; set; }

		public string SoHDFilter { get; set; }

		public string DonViCongTacNameFilter { get; set; }

		public string ChoNgoiFilter { get; set; }

		public int? MaxNoiDaoTaoIDFilter { get; set; }
		public int? MinNoiDaoTaoIDFilter { get; set; }

		public int? MaxLoaiHopDongIDFilter { get; set; }
		public int? MinLoaiHopDongIDFilter { get; set; }

		public string MaSoNoiKCBFilter { get; set; }

		public int? MaxNoiDangKyKCBIDFilter { get; set; }
		public int? MinNoiDangKyKCBIDFilter { get; set; }

		public DateTime? MaxNgayHetHanBHYTFilter { get; set; }
		public DateTime? MinNgayHetHanBHYTFilter { get; set; }

		public string SoTheBHYTFilter { get; set; }

		public string MaTinhCapFilter { get; set; }

		public string MaSoBHXHFilter { get; set; }

		public string SoSoBHXHFilter { get; set; }

		public double? MaxTyLeDongBHFilter { get; set; }
		public double? MinTyLeDongBHFilter { get; set; }

		public DateTime? MaxNgayThamGiaBHFilter { get; set; }
		public DateTime? MinNgayThamGiaBHFilter { get; set; }

		public int ThamGiaCongDoanFilter { get; set; }

		public string NganHangCodeFilter { get; set; }

		public string TkNganHangFilter { get; set; }

		public string DonViSoCongChuanCodeFilter { get; set; }

		public string SoCongChuanFilter { get; set; }

		public string LuongDongBHFilter { get; set; }

		public string LuongCoBanFilter { get; set; }

		public string BacLuongCodeFilter { get; set; }

		public double? MaxSoNgayPhepFilter { get; set; }
		public double? MinSoNgayPhepFilter { get; set; }

		public DateTime? MaxNgayChinhThucFilter { get; set; }
		public DateTime? MinNgayChinhThucFilter { get; set; }

		public DateTime? MaxNgayThuViecFilter { get; set; }
		public DateTime? MinNgayThuViecFilter { get; set; }

		public DateTime? MaxNgayTapSuFilter { get; set; }
		public DateTime? MinNgayTapSuFilter { get; set; }

		public string SoSoQLLaoDongFilter { get; set; }

		public string DiaDiemLamViecCodeFilter { get; set; }

		public string QuanLyGianTiepFilter { get; set; }

		public string QuanLyTrucTiepFilter { get; set; }

		public string TrangThaiLamViecCodeFilter { get; set; }

		public string BacFilter { get; set; }

		public string CapFilter { get; set; }

		public string ChucDanhFilter { get; set; }

		public string MaChamCongFilter { get; set; }

		public string DiaChiLHKCFilter { get; set; }

		public string EmailLHKCFilter { get; set; }

		public string DtDiDongLHKCFilter { get; set; }

		public string DtNhaRiengLHKCFilter { get; set; }

		public string QuanHeLHKCFilter { get; set; }

		public string HoVaTenLHKCFilter { get; set; }

		public string DiaChiHNFilter { get; set; }

		public int? MaxTinhThanhIDHNFilter { get; set; }
		public int? MinTinhThanhIDHNFilter { get; set; }

		public string QuocGiaHNFilter { get; set; }

		public int LaChuHoFilter { get; set; }

		public string MaSoHoGiaDinhFilter { get; set; }

		public string SoSoHoKhauFilter { get; set; }

		public string DiaChiHKTTFilter { get; set; }

		public int? MaxTinhThanhIDHKTTFilter { get; set; }
		public int? MinTinhThanhIDHKTTFilter { get; set; }

		public string QuocGiaHKTTFilter { get; set; }

		public string FacebookFilter { get; set; }

		public string SkypeFilter { get; set; }

		public string NoiSinhFilter { get; set; }

		public int? MaxTinhThanhIDFilter { get; set; }
		public int? MinTinhThanhIDFilter { get; set; }

		public string NguyenQuanFilter { get; set; }

		public string EmailKhacFilter { get; set; }

		public string EmailCoQuanFilter { get; set; }

		public string EmailCaNhanFilter { get; set; }

		public string DtKhacFilter { get; set; }

		public string DtNhaRiengFilter { get; set; }

		public string DtCoQuanFilter { get; set; }

		public string DtDiDongFilter { get; set; }

		public string TepDinhKemFilter { get; set; }

		public string TinhTrangHonNhanCodeFilter { get; set; }

		public string XepLoaiCodeFilter { get; set; }

		public int? MaxNamTotNghiepFilter { get; set; }
		public int? MinNamTotNghiepFilter { get; set; }

		public string ChuyenNganhFilter { get; set; }

		public string KhoaFilter { get; set; }

		public string TrinhDoDaoTaoCodeFilter { get; set; }

		public string TrinhDoVanHoaFilter { get; set; }

		public DateTime? MaxNgayHetHanFilter { get; set; }
		public DateTime? MinNgayHetHanFilter { get; set; }

		public string NoiCapFilter { get; set; }

		public DateTime? MaxNgayCapFilter { get; set; }
		public DateTime? MinNgayCapFilter { get; set; }

		public string SoCMNDFilter { get; set; }

		public string QuocTichFilter { get; set; }

		public string TonGiaoFilter { get; set; }

		public string DanTocFilter { get; set; }

		public string ViTriCongViecCodeFilter { get; set; }

		public int? MaxDonViCongTacIDFilter { get; set; }
		public int? MinDonViCongTacIDFilter { get; set; }

		public string MSTCaNhanFilter { get; set; }

		public DateTime? MaxNgaySinhFilter { get; set; }
		public DateTime? MinNgaySinhFilter { get; set; }

		public string GioiTinhCodeFilter { get; set; }

		public string AnhDaiDienFilter { get; set; }

		public string HoVaTenFilter { get; set; }

		public string MaNhanVienFilter { get; set; }

		public string ChiNhanhFilter { get; set; }

		public string DVTFilter { get; set; }

		public DateTime? MaxNgayKyHDKTHFilter { get; set; }
		public DateTime? MinNgayKyHDKTHFilter { get; set; }

		public DateTime? MaxNgayKyHD36THFilter { get; set; }
		public DateTime? MinNgayKyHD36THFilter { get; set; }

		public DateTime? MaxNgayKyHD12THFilter { get; set; }
		public DateTime? MinNgayKyHD12THFilter { get; set; }

		public DateTime? MaxNgayKyHDTVFilter { get; set; }
		public DateTime? MinNgayKyHDTVFilter { get; set; }

		public DateTime? MaxNgayKYHDCTVFilter { get; set; }
		public DateTime? MinNgayKYHDCTVFilter { get; set; }

		public DateTime? MaxNgayKyHDKVFilter { get; set; }
		public DateTime? MinNgayKyHDKVFilter { get; set; }

		public DateTime? MaxNgayKYHDTTFilter { get; set; }
		public DateTime? MinNgayKYHDTTFilter { get; set; }

		public DateTime? MaxNgayKyHDFilter { get; set; }
		public DateTime? MinNgayKyHDFilter { get; set; }



	}

}