package com.kh.zoopiter.dao;

import com.kh.zoopiter.domain.entity.BBSH;
import com.kh.zoopiter.domain.BBSH.dao.BBSHDAO;
import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.Optional;


@SpringBootTest
public class BBSHDAOImplTest {

  private BBSHDAO bbsHDao;

  @Autowired
  public void setBbsHDao(BBSHDAO bbsHDao) {
    this.bbsHDao = bbsHDao;
  }
  // 등록
//  @Test
//  @Order(1)
//  @DisplayName("공지등록")
//  void save() {
//    BBSH bbsh = new BBSH();
//
//    bbsh.setBhTitle("타이틀");
//    bbsh.setBhContent("내용");
//
//    Long save = BBSHDAO.save(bbsh);
//
////    Assertions.assertThat(save.getTitle()).isEqualTo("타이틀");
////    log.info("save={}", save);
//
//  }


  //수정
//  @Test
//  @Order(2)
//  @DisplayName("공지수정")
//  void update(){
//    Long id = 1L;
//    Notice notice = new Notice();
//    notice.setTitle("제목22");
//    notice.setContent("내용22");
//    int updatedRowCount = BBSHDAO.update(id, notice);
//    Optional<Notice> findedNotice = BBSHDAO.findById(id);
//
//    Assertions.assertThat(updatedRowCount).isEqualTo(1);
//    Assertions.assertThat(findedNotice.get().getTitle()).isEqualTo(notice.getTitle());
//    Assertions.assertThat(findedNotice.get().getContent()).isEqualTo(notice.getContent());
//  }
//
   // 삭제
//  @Test
//  @DisplayName("공지삭제")
//  void delete(){
//    Long bbshId = 202L;
//    int deletedRowCount = BBSHDAO.delete(bbshId);
//    Optional<BBSH> findedBBSH = BBSHDAO.findById(bbshId);
//
//    Assertions.assertThatThrownBy(()->findedBBSH.orElseThrow())
//            .isInstanceOf(NoSuchMethodException.class);
//  }
//  @Test
//  void increaseHitCount() {
//    Long bbsId = 1L;
//    //조회전 조회수
//    int beforeHitCount = bbsHDao.findById(bbsId).orElseThrow().getBhHit();
//    //조회
//    bbsHDao.increaseHitCount(1L);
//    //조회후 조회수
//    int afterHitCount = bbsHDao.findById(bbsId).orElseThrow().getBhHit();
//    //조회후 조회수 - 조회전 조회수 = 1
//    Assertions.assertThat(afterHitCount - beforeHitCount).isEqualTo(1);
//  }

}
//
//  @Test
//  @DisplayName("공지목록")
//  void findAll(){
//    List<Notice> list = BBSHDAO.findAll();
//
//    Assertions.assertThat(list.size()).isGreaterThan(0);
//
//  }
//
//}
