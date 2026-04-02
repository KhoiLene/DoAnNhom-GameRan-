using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom_GameRan_
{
    public class LanguageManager
    {
        public static Dictionary<string, Dictionary<string, string>> data =
        new Dictionary<string, Dictionary<string, string>>()
        {
           // ===== MENU =====
            { "start_menu", new Dictionary<string, string>()
                {
                    { "vi", "BẮT ĐẦU" },
                    { "en", "START" },
                    { "ja", "スタート" },
                    { "zh", "开始" },
                    { "ko", "시작" }
                }
            },

            { "start", new Dictionary<string, string>()
                {
                    { "vi", "Bắt đầu" },
                    { "en", "Start" },
                    { "ja", "スタート" },
                    { "zh", "开始" },
                    { "ko", "시작" }
                }
            },

            { "guest", new Dictionary<string, string>()
                {
                    { "vi", "Khách" },
                    { "en", "Guest" },
                    { "ja", "ゲスト" },
                    { "zh", "游客" },
                    { "ko", "게스트" }
                }
            },

            { "login", new Dictionary<string, string>()
                {
                    { "vi", "Đăng nhập" },
                    { "en", "Login" },
                    { "ja", "ログイン" },
                    { "zh", "登录" },
                    { "ko", "로그인" }
                }
            },

            { "back", new Dictionary<string, string>()
                {
                    { "vi", "Quay lại" },
                    { "en", "Back" },
                    { "ja", "戻る" },
                    { "zh", "返回" },
                    { "ko", "뒤로" }
                }
            },

            { "must_choose_user", new Dictionary<string, string>()
                {
                    { "vi", "Bạn phải chọn Guest hoặc Login trước khi chơi!" },
                    { "en", "You must choose Guest or Login before playing!" },
                    { "ja", "プレイする前にゲストまたはログインを選択してください！" },
                    { "zh", "开始游戏前必须选择游客或登录！" },
                    { "ko", "플레이 전에 게스트 또는 로그인을 선택해야 합니다!" }
                }
            },

            { "guest_confirm", new Dictionary<string, string>()
                {
                    { "vi", "Bạn chọn chơi với tư cách Khách.\nNhấn OK để tiếp tục." },
                    { "en", "You chose to play as Guest.\nPress OK to continue." },
                    { "ja", "ゲストとしてプレイします。\nOKを押して続行してください。" },
                    { "zh", "您选择以游客身份游玩。\n点击确定继续。" },
                    { "ko", "게스트로 플레이합니다.\n확인을 눌러 계속하세요." }
                }
            },

            { "guest_title", new Dictionary<string, string>()
                {
                    { "vi", "Xác nhận Khách" },
                    { "en", "Guest Confirmation" },
                    { "ja", "ゲスト確認" },
                    { "zh", "游客确认" },
                    { "ko", "게스트 확인" }
                }
            },

            // ===== REGISTER =====
            { "register_account", new Dictionary<string, string>()
                {
                    { "vi", "Đăng ký tài khoản" },
                    { "en", "Register Account" },
                    { "ja", "アカウント登録" },
                    { "zh", "注册账号" },
                    { "ko", "회원 가입" }
                }
            },

            { "email", new Dictionary<string, string>()
                {
                    { "vi", "Email" },
                    { "en", "Email" },
                    { "ja", "メール" },
                    { "zh", "邮箱" },
                    { "ko", "이메일" }
                }
            },

            { "username", new Dictionary<string, string>()
                {
                    { "vi", "Tên đăng nhập" },
                    { "en", "Username" },
                    { "ja", "ユーザー名" },
                    { "zh", "用户名" },
                    { "ko", "아이디" }
                }
            },

            { "password", new Dictionary<string, string>()
                {
                    { "vi", "Mật khẩu" },
                    { "en", "Password" },
                    { "ja", "パスワード" },
                    { "zh", "密码" },
                    { "ko", "비밀번호" }
                }
            },

            { "confirm_password", new Dictionary<string, string>()
                {
                    { "vi", "Nhập lại mật khẩu" },
                    { "en", "Confirm Password" },
                    { "ja", "パスワード確認" },
                    { "zh", "确认密码" },
                    { "ko", "비밀번호 확인" }
                }
            },

            { "show_password", new Dictionary<string, string>()
                {
                    { "vi", "Hiện mật khẩu" },
                    { "en", "Show Password" },
                    { "ja", "パスワード表示" },
                    { "zh", "显示密码" },
                    { "ko", "비밀번호 표시" }
                }
            },

            { "register", new Dictionary<string, string>()
                {
                    { "vi", "Đăng ký" },
                    { "en", "Register" },
                    { "ja", "登録" },
                    { "zh", "注册" },
                    { "ko", "회원가입" }
                }
            },

            { "fill_all_fields", new Dictionary<string, string>()
                {
                    { "vi", "Vui lòng nhập đầy đủ thông tin!" },
                    { "en", "Please fill in all fields!" },
                    { "ja", "すべての情報を入力してください！" },
                    { "zh", "请填写所有信息！" },
                    { "ko", "모든 정보를 입력해주세요!" }
                }
            },

            { "email_exists", new Dictionary<string, string>()
                {
                    { "vi", "Email đã tồn tại!" },
                    { "en", "Email already exists!" },
                    { "ja", "メールはすでに存在します！" },
                    { "zh", "邮箱已存在！" },
                    { "ko", "이메일이 이미 존재합니다!" }
                }
            },

            { "username_exists", new Dictionary<string, string>()
                {
                    { "vi", "Tên đăng nhập đã tồn tại!" },
                    { "en", "Username already exists!" },
                    { "ja", "ユーザー名はすでに存在します！" },
                    { "zh", "用户名已存在！" },
                    { "ko", "아이디가 이미 존재합니다!" }
                }
            },

            // ===== LOGIN =====
            { "email_or_username", new Dictionary<string, string>()
                {
                    { "vi", "Email hoặc tên đăng nhập" },
                    { "en", "Email or Username" },
                    { "ja", "メールまたはユーザー名" },
                    { "zh", "邮箱或用户名" },
                    { "ko", "이메일 또는 아이디" }
                }
            },

            { "no_account", new Dictionary<string, string>()
                {
                    { "vi", "Bạn chưa có tài khoản?" },
                    { "en", "Don't have an account?" },
                    { "ja", "アカウントをお持ちでないですか？" },
                    { "zh", "还没有账号？" },
                    { "ko", "계정이 없으신가요?" }
                }
            },

            { "forgot_password", new Dictionary<string, string>()
                {
                    { "vi", "Quên mật khẩu" },
                    { "en", "Forgot Password" },
                    { "ja", "パスワードを忘れた" },
                    { "zh", "忘记密码" },
                    { "ko", "비밀번호 찾기" }
                }
            },

            { "login_success", new Dictionary<string, string>()
                {
                    { "vi", "Đăng nhập thành công!" },
                    { "en", "Login successful!" },
                    { "ja", "ログイン成功！" },
                    { "zh", "登录成功！" },
                    { "ko", "로그인 성공!" }
                }
            },

             { "login_failed", new Dictionary<string, string>()
                {
                    { "vi", "Tên đăng nhập hoặc mật khẩu không đúng." },
                    { "en", "Incorrect username or password." },
                    { "ja", "ユーザー名またはパスワードが正しくありません。" },
                    { "zh", "用户名或密码错误。" },
                    { "ko", "아이디 또는 비밀번호가 올바르지 않습니다." }
                }
             },

            // ===== GAME =====
            { "select_level", new Dictionary<string, string>()
                {
                    { "vi", "Chọn màn" },
                    { "en", "Select Level" },
                    { "ja", "レベル選択" },
                    { "zh", "选择关卡" },
                    { "ko", "레벨 선택" }
                }
            },

            { "level", new Dictionary<string, string>()
                {
                    { "vi", "Màn" },
                    { "en", "Level" },
                    { "ja", "レベル" },
                    { "zh", "关卡" },
                    { "ko", "레벨" }
                }
            },

            { "snap", new Dictionary<string, string>()
                 {
                    { "vi", "Chơi nhanh" },
                    { "en", "Snap" },
                    { "ja", "スナップ" },
                    { "zh", "快速游戏" },
                    { "ko", "스냅" }
                 }
            },

            { "server_high_score", new Dictionary<string, string>()
                 {
                     { "vi", "Điểm cao máy chủ" },
                     { "en", "Server High Score" },
                     { "ja", "サーバーハイスコア" },
                     { "zh", "服务器最高分" },
                     { "ko", "서버 최고 점수" }
                 }
            },

            { "high_score", new Dictionary<string, string>()
                 {
                     { "vi", "Điểm cao" },
                     { "en", "High Score" },
                     { "ja", "ハイスコア" },
                     { "zh", "最高分" },
                     { "ko", "최고 점수" }
                 }
            },

            { "score", new Dictionary<string, string>()
                {
                    { "vi", "Điểm" },
                    { "en", "Score" },
                    { "ja", "スコア" },
                    { "zh", "分数" },
                    { "ko", "점수" }
                }
            },

            { "level_locked", new Dictionary<string, string>()
                {
                    { "vi", "Màn {0} chưa được mở khóa!" },
                    { "en", "Level {0} is not unlocked yet!" },
                    { "ja", "レベル {0} はまだ解除されていません！" },
                    { "zh", "第 {0} 关尚未解锁！" },
                    { "ko", "레벨 {0}은 아직 잠금 해제되지 않았습니다!" }
                }
            },

            { "notification", new Dictionary<string, string>()
                {
                    { "vi", "Thông báo" },
                    { "en", "Notification" },
                    { "ja", "通知" },
                    { "zh", "通知" },
                    { "ko", "알림" }
                }
            },

            // ===== SETTINGS =====
            { "settings", new Dictionary<string, string>()
                {
                    { "vi", "Cài đặt" },
                    { "en", "Settings" },
                    { "ja", "設定" },
                    { "zh", "设置" },
                    { "ko", "설정" }
                }
            },

            { "language", new Dictionary<string, string>()
                {
                    { "vi", "Ngôn ngữ" },
                    { "en", "Language" },
                    { "ja", "言語" },
                    { "zh", "语言" },
                    { "ko", "언어" }
                }
            },

            { "volume", new Dictionary<string, string>()
                {
                    { "vi", "Âm lượng" },
                    { "en", "Volume" },
                    { "ja", "音量" },
                    { "zh", "音量" },
                    { "ko", "볼륨" }
                }
            },

            { "sound_toggle", new Dictionary<string, string>()
                {
                    { "vi", "Âm thanh Bật/Tắt" },
                    { "en", "Sound On/Off" },
                    { "ja", "音 オン/オフ" },
                    { "zh", "声音 开/关" },
                    { "ko", "소리 켜기/끄기" }
                }
            },

            { "on", new Dictionary<string, string>()
                {
                    { "vi", "Bật" },
                    { "en", "On" },
                    { "ja", "オン" },
                    { "zh", "开" },
                    { "ko", "켜짐" }
                }
            },

            { "off", new Dictionary<string, string>()
                {
                    { "vi", "Tắt" },
                    { "en", "Off" },
                    { "ja", "オフ" },
                    { "zh", "关" },
                    { "ko", "꺼짐" }
                }
            },

            { "save", new Dictionary<string, string>()
                {
                    { "vi", "Lưu" },
                    { "en", "Save" },
                    { "ja", "保存" },
                    { "zh", "保存" },
                    { "ko", "저장" }
                }
            },

            { "cancel", new Dictionary<string, string>()
                {
                    { "vi", "Hủy" },
                    { "en", "Cancel" },
                    { "ja", "キャンセル" },
                    { "zh", "取消" },
                    { "ko", "취소" }
                }
            },

            { "settings_saved", new Dictionary<string, string>()
                {
                    { "vi", "Cài đặt đã được lưu thành công!" },
                    { "en", "Settings saved successfully!" },
                    { "ja", "設定が正常に保存されました！" },
                    { "zh", "设置已成功保存！" },
                    { "ko", "설정이 성공적으로 저장되었습니다!" }
                }
            },

            //OTP
            { "confirm", new Dictionary<string, string>()
                {
                    { "vi", "Xác nhận" },
                    { "en", "Confirm" },
                    { "ja", "確認" },
                    { "zh", "确认" },
                    { "ko", "확인" }
                }
            },

            { "otp", new Dictionary<string, string>()
                {
                    { "vi", "Mã OTP" },
                    { "en", "OTP Code" },
                    { "ja", "OTPコード" },
                    { "zh", "OTP验证码" },
                    { "ko", "OTP 코드" }
                }
            },

            { "otp_correct", new Dictionary<string, string>()
                {
                    { "vi", "OTP đúng!" },
                    { "en", "Correct OTP!" },
                    { "ja", "OTPが正しいです！" },
                    { "zh", "OTP正确！" },
                    { "ko", "OTP가 올바릅니다!" }
                }
            },

            { "otp_incorrect", new Dictionary<string, string>()
                {
                    { "vi", "OTP sai!" },
                    { "en", "Incorrect OTP!" },
                    { "ja", "OTPが間違っています！" },
                    { "zh", "OTP错误！" },
                    { "ko", "OTP가 잘못되었습니다!" }
                }
            },

            { "register_success", new Dictionary<string, string>()
                {
                    { "vi", "Đăng ký thành công!" },
                    { "en", "Registration successful!" },
                    { "ja", "登録成功！" },
                    { "zh", "注册成功！" },
                    { "ko", "회원가입 성공!" }
                }
            },

            //Email
            { "receive_otp", new Dictionary<string, string>()
                {
                    { "vi", "Nhận mã OTP" },
                    { "en", "Receive OTP" },
                    { "ja", "OTPを受け取る" },
                    { "zh", "接收OTP验证码" },
                    { "ko", "OTP 받기" }
                }
            },

            { "email_not_exist", new Dictionary<string, string>()
                {
                    { "vi", "Email không tồn tại!" },
                    { "en", "Email does not exist!" },
                    { "ja", "メールが存在しません！" },
                    { "zh", "邮箱不存在！" },
                    { "ko", "이메일이 존재하지 않습니다!" }
                }
            },

            { "otp_sent", new Dictionary<string, string>()
                {
                    { "vi", "OTP đã gửi đến email!" },
                    { "en", "OTP has been sent to your email!" },
                    { "ja", "OTPがメールに送信されました！" },
                    { "zh", "OTP验证码已发送到您的邮箱！" },
                    { "ko", "OTP가 이메일로 전송되었습니다!" }
                }
            },

            //Password
            { "enter_password", new Dictionary<string, string>()
                {
                    { "vi", "Vui lòng nhập mật khẩu!" },
                    { "en", "Please enter password!" },
                    { "ja", "パスワードを入力してください！" },
                    { "zh", "请输入密码！" },
                    { "ko", "비밀번호를 입력해주세요!" }
                }
            },

            { "password_not_match", new Dictionary<string, string>()
                {
                    { "vi", "Mật khẩu không khớp!" },
                    { "en", "Passwords do not match!" },
                    { "ja", "パスワードが一致しません！" },
                    { "zh", "密码不匹配！" },
                    { "ko", "비밀번호가 일치하지 않습니다!" }
                }
            },

            { "account_not_found", new Dictionary<string, string>()
                {
                    { "vi", "Không tìm thấy tài khoản!" },
                    { "en", "Account not found!" },
                    { "ja", "アカウントが見つかりません！" },
                    { "zh", "未找到账号！" },
                    { "ko", "계정을 찾을 수 없습니다!" }
                }
            },

            { "update_success", new Dictionary<string, string>()
                {
                    { "vi", "Cập nhật thành công!" },
                    { "en", "Update successful!" },
                    { "ja", "更新成功！" },
                    { "zh", "更新成功！" },
                    { "ko", "업데이트 성공!" }
                }
            },

            { "password_changed", new Dictionary<string, string>()
                {
                    { "vi", "Đổi mật khẩu thành công!" },
                    { "en", "Password changed successfully!" },
                    { "ja", "パスワード変更成功！" },
                    { "zh", "密码修改成功！" },
                    { "ko", "비밀번호 변경 성공!" }
                }
            },

            { "restart", new Dictionary<string, string>()
                {
                    { "vi", "Chơi lại" },
                    { "en", "Restart" },
                    { "ja", "リスタート" },
                    { "zh", "重新开始" },
                    { "ko", "다시 시작" }
                }
            },

            { "game_over", new Dictionary<string, string>()
                {
                    { "vi", "Thất bại!" },
                    { "en", "Game Over!" },
                    { "ja", "ゲームオーバー！" },
                    { "zh", "游戏结束！" },
                    { "ko", "게임 오버!" }
                }
            },

            { "poison_apple_die", new Dictionary<string, string>()
                {
                    { "vi", "Bạn đã ăn phải táo độc và rắn quá ngắn để sống sót!" },
                    { "en", "You ate a poisoned apple and the snake is too short to survive!" },
                    { "ja", "毒リンゴを食べてしまい、ヘビが短すぎて生き残れません！" },
                    { "zh", "你吃了毒苹果，蛇太短无法生存！" },
                    { "ko", "독이 든 사과를 먹었고 뱀이 너무 짧아 생존할 수 없습니다!" }
                }
            },

            { "snapshot_text", new Dictionary<string, string>()
                {
                    { "vi", "Tôi đạt: {0} điểm và điểm cao nhất là {1}" },
                    { "en", "I scored: {0} and my Highscore is {1}" },
                    { "ja", "スコア: {0}、ハイスコア: {1}" },
                    { "zh", "我的得分: {0}，最高分: {1}" },
                    { "ko", "점수: {0}, 최고 점수: {1}" }
                }
            },

            { "score_format", new Dictionary<string, string>()
                {
                    { "vi", "Điểm: {0}" },
                    { "en", "Score: {0}" },
                    { "ja", "スコア: {0}" },
                    { "zh", "分数: {0}" },
                    { "ko", "점수: {0}" }
                }
            },

            { "hit_enemy", new Dictionary<string, string>()
                {
                    { "vi", "Bạn đụng rắn phụ!" },
                    { "en", "You hit the enemy snake!" },
                    { "ja", "敵のヘビにぶつかりました！" },
                    { "zh", "你撞到敌方蛇了！" },
                    { "ko", "적 뱀에 부딪혔습니다!" }
                }
            },

            { "poison_apple", new Dictionary<string, string>()
                {
                    { "vi", "Bạn ăn phải táo độc!" },
                    { "en", "You ate a poisoned apple!" },
                    { "ja", "毒リンゴを食べてしまいました！" },
                    { "zh", "你吃了毒苹果！" },
                    { "ko", "독이 든 사과를 먹었습니다!" }
                }
            },

            { "pause_before_snap", new Dictionary<string, string>()
                {
                    { "vi", "Hãy tạm dừng game trước khi chụp!" },
                    { "en", "Pause the game before taking a snapshot!" },
                    { "ja", "スクリーンショットの前にゲームを一時停止してください！" },
                    { "zh", "截图前请先暂停游戏！" },
                    { "ko", "스크린샷을 찍기 전에 게임을 일시정지하세요!" }
                }
            },

            { "exit_confirm", new Dictionary<string, string>()
                {
                    { "vi", "Bạn có chắc muốn thoát game?" },
                    { "en", "Are you sure you want to exit the game?" },
                    { "ja", "ゲームを終了してもよろしいですか？" },
                    { "zh", "您确定要退出游戏吗？" },
                    { "ko", "게임을 종료하시겠습니까?" }
                }
            },

            { "exit_title", new Dictionary<string, string>()
                {
                    { "vi", "Thoát" },
                    { "en", "Exit" },
                    { "ja", "終了" },
                    { "zh", "退出" },
                    { "ko", "종료" }
                }
            }
        };

        public static string Get(string key)
        {
            string lang = Properties.Settings.Default.Language;

            key = key.ToLower(); // 🔥 fix

            if (data.ContainsKey(key) && data[key].ContainsKey(lang))
                return data[key][lang];

            return key;
        }

        // 🔥 AUTO APPLY CHO TOÀN FORM
        public static void ApplyLanguage(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Tag != null)
                {
                    string key = c.Tag.ToString().ToLower();
                    c.Text = Get(key);
                }

                // đệ quy cho control con
                if (c.HasChildren)
                    ApplyLanguage(c);
            }

        }
    }
}
